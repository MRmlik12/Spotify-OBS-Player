 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Spotify_OBS_Player.Update
{
    public class GetLatestVersion
    {
        private int versionCode = 3;

        private async Task<string> DownloadLatestInfo()
        {
            try
            {
                string url = "https://spotify-obs-player-api.herokuapp.com/";

                var http = new HttpClient();
                var request = new HttpRequestMessage(new HttpMethod("GET"), url);

                HttpResponseMessage message = await http.SendAsync(request);
                return await message.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Cannot connect to the serwer!", "Spotify OBS Player",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }

        private async Task<List<string>> DeserializeLatest()
        {
            var deserialize = JsonConvert.DeserializeObject<RootObject>(await DownloadLatestInfo());
            List<string> items = new List<string>
            {
                deserialize.version,
                deserialize.version_code.ToString(),
            };
            return items;
        }

        public static async void CheckVersion()
        {
            try
            {
                GetLatestVersion GetLatestVersion = new GetLatestVersion();
                List<string> deserialize = await GetLatestVersion.DeserializeLatest();
                int checkedVersion = Convert.ToInt32(deserialize[1]);

                if (checkedVersion > GetLatestVersion.versionCode)
                {
                    string message = $"Do you want update to {deserialize[0]} version?";
                    string caption = "Spotify OBS Player";
                    var buttons = MessageBoxButtons.YesNo;
                    var icon = MessageBoxIcon.Question;

                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons, icon);
                    if (result == DialogResult.Yes)
                    {
                        var processInfo = new ProcessStartInfo();
                        processInfo.FileName = "Updater.exe";
                        //processInfo.Arguments = "-5";
                        Process.Start(processInfo);
                        Application.Exit();
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
