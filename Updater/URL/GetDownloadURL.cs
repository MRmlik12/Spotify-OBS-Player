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

namespace Updater.URL
{
    public class GetDownloadURL
    {
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
                MessageBox.Show("Updating failed! Please check your connection.");
                Application.Exit();
                return null;
            }
        }

        public static async Task<string> GetURL()
        {
            var latest = new GetDownloadURL();
            var deserialize = JsonConvert.DeserializeObject<RootObject>(await latest.DownloadLatestInfo());
            return deserialize.download_url;
        }
    }
}
