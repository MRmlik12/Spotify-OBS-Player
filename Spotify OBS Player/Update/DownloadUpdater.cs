using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;

namespace Spotify_OBS_Player.Update
{
    public class DownloadUpdater
    {
        int build = 1;
        string url = "https://spotify-obs-player-api.herokuapp.com/updater";

        public void CheckUpdater()
        {
            bool file = File.Exists("Updater.exe");
            
            if (file == false)
            {
                Download();
            }
        }

        public Task<string> GetFileInfo()
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage RequestMessage = new HttpRequestMessage(new HttpMethod("GET"), url);

            var response = client.SendAsync(RequestMessage);
            return response.Result.Content.ReadAsStringAsync();
        }

        public async Task<string> Deserialize()
        {
            var json = JsonConvert.DeserializeObject<Updater.RootObject>(await GetFileInfo());
            return json.download_url;
            
        }

        public async void Download()
        {
            WebClient client = new WebClient();
            client.DownloadFileAsync(new Uri(await Deserialize()), "Updater.exe");
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Completed");
        }
    }
}
