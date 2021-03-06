﻿using System;
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
using Spotify_OBS_Player.Config;

namespace Spotify_OBS_Player.Forms
{
    public partial class Playback : Form
    {
        public string token;
        public string refreshToken;
        public Thread thread = null;
        public int updateTime;
        public bool closeThread = true;

        public Playback()
        {
            InitializeComponent();
        }

        private void Playback_Load(object sender, EventArgs e)
        {
            ConfigOperations config = new ConfigOperations();
            var values = config.LoadValuesFromConfig();

            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile("Fonts/Montserrat-Bold.ttf");
            font.AddFontFile("Fonts/Montserrat-Regular.ttf");
            Title.Font = new Font(font.Families[0], Convert.ToSingle(values[3]), FontStyle.Bold);
            Artist.Font = new Font(font.Families[0], Convert.ToSingle(values[4]), FontStyle.Regular);
    

            this.BackColor = ColorTranslator.FromHtml(values[2]);
            Title.BackColor = ColorTranslator.FromHtml(values[2]);
            Artist.BackColor = ColorTranslator.FromHtml(values[2]);

            Title.ForeColor = ColorTranslator.FromHtml(values[1]);
            Artist.ForeColor = ColorTranslator.FromHtml(values[1]);

            updateTime = Convert.ToInt32(values[0]);
        }

        private void Artist_Click(object sender, EventArgs e)
        {

        }

        private async void Playback_Shown(object sender, EventArgs e)
        {
            Spotify Spotify = new Spotify();
            var artists = await Spotify.GetCurrentTrackInfo(token, refreshToken);
            if (artists == null)
            {
                closeThread = false;
                this.Close();
            }
            else
            {
                Title.Text = Spotify.title;
                Artist.Text = string.Join(", ", artists);
                Thumbnail.Load(Spotify.imageUrl);
                thread = new Thread(this.Update);

                thread.Start();
            }
        }

        private new async void Update()
        {
            while (true)
            {
                Thread.Sleep(updateTime * 1000);
                Spotify Spotify = new Spotify();
                var artists = await Spotify.GetCurrentTrackInfo(token, refreshToken);
                if (artists[0] == "token")
                {
                    token = artists[1];
                    refreshToken = artists[2];
                }
                else if (artists == null)
                    this.Close();
                else if (artists[0] == "False")
                    Console.WriteLine("Please Turn On Music");
                else
                {
                    try
                    {
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
                    catch (InvalidOperationException)
                    {

                    }
                }
            }
        }

        private void Playback_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Playback_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeThread == true)
            {
                thread.Abort();
            }
            this.Dispose(true);
        }
    }
}
