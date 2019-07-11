using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Collections.Specialized;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;

namespace Spotify_OBS_Player.API
{
    public class Spotify
    {
        protected readonly string url = "https://api.spotify.com/v1/";

        private readonly string clientID = "";
        private readonly string secretID = "";

        public string newToken;
        public List<string> Artists = new List<string> { };
        public string title = null;
        public string imageUrl = null;

        public string Auth(string code)
        {
            string token = GetToken(code);
            return token;
        }

        public string[] GetTokenFromJSON(string jsonToken)
        {
            var deserializer = JsonConvert.DeserializeObject<TokenData.RootObject>(GetToken(jsonToken));

            string[] important = new string[2];
            important[0] = deserializer.access_token;
            important[1] = deserializer.refresh_token;

            return important;
        }

        private string GetToken(string code)
        {
            var postparams = new NameValueCollection();
            postparams.Add("grant_type", "authorization_code");
            postparams.Add("code", code);
            postparams.Add("redirect_uri", "http://localhost:8888/callback/");

            var webClient = new WebClient();
            string encode = Convert.ToBase64String(Encoding.Default.GetBytes($"{clientID}:{secretID}"));
            webClient.Headers.Add(HttpRequestHeader.Authorization, $"Basic {encode}");

            var response = webClient.UploadValues("https://accounts.spotify.com/api/token", postparams);
            string json = Encoding.UTF8.GetString(response);
            return json;            
        }

        public async Task<List<string>> GetCurrentTrackInfo(string token, string refreshToken = null)
        {
            var response = await DownloadCurrentTrackInfo(token);
            if (response == "")
            {
                MessageBox.Show("Unable to get data from api! Come back later!",
                    "Spotify OBS Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Artists = null;
            }
            else if (response == "get new token")
            {
                newToken = await RefreshToken(refreshToken);
                var deserializer = JsonConvert.DeserializeObject<TokenData.RootObject>(newToken);
                Artists.Add("token");
                Artists.Add(deserializer.access_token);
                Artists.Add(deserializer.refresh_token);
                return Artists;
            }
            else
            {
                var json =
                    JsonConvert.DeserializeObject<TrackInfo.RootObject>(response);
                while (true)
                {
                    response = await DownloadCurrentTrackInfo(token);
                    json = JsonConvert.DeserializeObject<TrackInfo.RootObject>(response);
                    if (json.is_playing == false)
                    {
                        MessageBox.Show("Please turn on music!", "OBS Spotify Player", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        break;
                    }
                }
                title = json.item.name;
                imageUrl = json.item.album.images[0].url;
                for (int i = 0; i < json.item.artists.Count; i++)
                {
                    var _arists = json.item.artists[i];
                    Artists.Add(_arists.name);
                }
            }
            return Artists;
        }

        public async void UserInfo(string token)
        {
            string json = await GetUserData(token);
            var deserializer = JsonConvert.DeserializeObject(json);
        }

        public async Task<string> GetUserData(string token)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(new HttpMethod("GET"), "https://api.spotify.com/v1/me");
            request.Headers.Add("Authorization", $"Bearer {token}");

            var json = await httpClient.SendAsync(request);
            return await json.Content.ReadAsStringAsync();
        }

        public async Task<string> RefreshToken(string refreshToken)
        {
            string encode = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientID}:{secretID}"));

            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(new HttpMethod("POST"), "https://accounts.spotify.com/api/token");
            request.Headers.Add("Authorization", "Basic " + encode);

            List<string> postparams = new List<string> { };
            postparams.Add("grant_type=refresh_token");
            postparams.Add("refresh_token=" + refreshToken);
            request.Content = new StringContent(string.Join("&", postparams), Encoding.UTF8, "application/x-www-form-urlencoded");

            var response = await httpClient.SendAsync(request);
            return await response.Content.ReadAsStringAsync();

        }

        private async Task<string> DownloadCurrentTrackInfo(string token)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(new HttpMethod("GET"), "https://api.spotify.com/v1/me/player/currently-playing");
            request.Headers.Add("Authorization", $"Bearer {token}");

            var response = await httpClient.SendAsync(request);
            var json = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == (HttpStatusCode)401)
            {
                json = "token";
                return json;
            }
            else
                return json;
        }
    }
}
