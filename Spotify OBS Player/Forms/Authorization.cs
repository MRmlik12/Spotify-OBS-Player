using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace Spotify_OBS_Player.Forms
{
    public partial class Authorization : Form
    {
        public bool removeAccount = false;
        string address = "https://accounts.spotify.com/authorize?response_type=code&" +
            "client_id=ddbd63299ab241d7ae4f3950da963343&scope=user-read-private%20user-read-email%20" +
            "user-read-currently-playing%20user-read-playback-state%20user-read-birthdate&" +
            "redirect_uri=http://localhost:8888/callback/";

        Spotify_OBS_Player.API.Spotify Spotify = new API.Spotify();

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            if(removeAccount == true)
            {
                
            }
            Browser.Navigate(address);
        }

        private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var uri = new Uri(Browser.Url.ToString());
            string key = HttpUtility.ParseQueryString(uri.Query).Get("code");
            
            if (uri.Host == "localhost")
            {
                string[] token = Spotify.GetTokenFromJSON(key);
                var playback = new Forms.Playback();
                playback.token = token[0];
                playback.refreshToken = token[1];
                playback.Show();
                this.Close();
            }
        }
    }
}
