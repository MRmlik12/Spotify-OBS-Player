using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spotify_OBS_Player.API;
using System.Threading;
using IniParser;
using IniParser.Model;

namespace Spotify_OBS_Player.Forms
{
    public partial class Playback : Form
    {
        public string token;
        public Thread thread;
        public int updateTime;

        public Playback()
        {
            InitializeComponent();
        }

        private async void Playback_Load(object sender, EventArgs e)
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile("Fonts/Montserrat-Bold.ttf");
            font.AddFontFile("Fonts/Montserrat-Regular.ttf");
            Title.Font = new Font(font.Families[0], 14, FontStyle.Bold);
            Artist.Font = new Font(font.Families[0], 10, FontStyle.Regular);

            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("config.conf");
            updateTime = Convert.ToInt32(data["Config"]["update_time"]);

        }

        private void Artist_Click(object sender, EventArgs e)
        {

        }

        private async void Playback_Shown(object sender, EventArgs e)
        {
            Spotify Spotify = new Spotify();
            var artists = await Spotify.GetCurrentTrackInfo(token);
            Title.Text = Spotify.title;
            Artist.Text = string.Join(", ", artists);
            Thumbnail.Load(Spotify.imageUrl);
            thread = new Thread(this.Update);
            
            thread.Start();
        }

        private new async void Update()
        {
            while (true)
            {
                Thread.Sleep(updateTime * 1000);
                Spotify Spotify = new Spotify();
                var artists = await Spotify.GetCurrentTrackInfo(token);
                Title.Invoke(new Action(delegate ()
                {
                    Title.Text = Spotify.title;
                }));

                Artist.Invoke(new Action(delegate ()
                {
                    Artist.Text = string.Join(", ", artists);
                }));

                Thumbnail.Invoke(new Action(delegate ()
                {
                    Thumbnail.Load(Spotify.imageUrl);

                }));
            }
        }

        private void Playback_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }
    }
}
