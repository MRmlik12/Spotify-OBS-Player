using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Diagnostics;
using Updater.URL;
using System.IO;

namespace Updater
{
    public partial class Updater : Form
    {
        public Thread thread;

        public Updater()
        {
            InitializeComponent();
        }

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
        private new async Task DownloadFile()
#pragma warning restore CS0109 // Member does not hide an inherited member; new keyword is not required
        {
            string url = await GetDownloadURL.GetURL();
            WebClient web = new WebClient();
            web.DownloadProgressChanged += Web_DownloadProgressChanged;
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadFileAsync(new Uri(url), "setup.exe");
        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "setup.exe";
            var p = Process.Start(processInfo);
            p.WaitForExit();
            Console.WriteLine(p.ExitCode);
            if (p.ExitCode == 1 || p.ExitCode == 2)
            {
               statusLabel.Invoke(new Action(delegate ()
               {
                   statusLabel.ForeColor = Color.Red;
                   statusLabel.Text = "Updating failed, Please try again later!";
               }));
            }
            else if (p.ExitCode == 0)
            {
                statusLabel.Invoke(new Action(delegate ()
                {
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "Success, your program was updated to newest version";
                }));
            }

            File.Delete("setup.exe");
            Thread.Sleep(5000);
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "Spotify OBS Player.exe";
            Process.Start(info);
            Invoke(new Action(delegate ()
            {
                Close();
            }));
        }

        private void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            updateLabel.Invoke(new Action(delegate ()
            {
                 updateLabel.Text= $"{e.BytesReceived}/{e.TotalBytesToReceive} bytes left";
            }));     
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            
        }

        private void Updater_Shown(object sender, EventArgs e)
        {
            thread = new Thread(() => DownloadFile());
            thread.Start();
        }

        private void Updater_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }
    }
}
