using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.IO;
using System.Diagnostics;
using Spotify_OBS_Player.Update;

namespace Spotify_OBS_Player
{
    public partial class Form1 : MaterialForm
    {
        Config.ConfigOperations ConfigOperations = new Config.ConfigOperations();

        public Form1()
        {
            DownloadUpdater updater = new DownloadUpdater();
            updater.CheckUpdater();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLatestVersion.CheckVersion();

            ConfigOperations.CheckConfig();
            if (ConfigOperations.create == false)
                this.Close();
            var values = ConfigOperations.LoadValuesFromConfig();
            UpdateTimeField.Text = values[0];
            TitleTextBox.Text = values[3];
            ArtistsTextBox.Text = values[4];
            if (values[1] == "default" || values[2] == "default")
            {
                FontColorTextBox.Text = "#FFFFFF";
                PlayerColorTextBox.Text = "#292828";
            }
            else
            {
                FontColorTextBox.Text = values[1];
                PlayerColorTextBox.Text = values[2];
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var Authorization = new Forms.Authorization();
            Authorization.Show();
        }

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            var about = new Forms.About();
            about.Show();
        }

        private void UpdateTimeField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfigOperations.SaveValuesToConfig(UpdateTimeField.Text);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("If you want edit data please run this program as a administator", 
                    "Spotify OBS Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please type a number, not character");
            }
        }

        private void RemoveBrowserCache_Click(object sender, EventArgs e)
        {
            var Authorization = new Forms.Authorization();
            Authorization.removeAccount = true;
            Authorization.Show();
        }

        private void UpdateTimeField_Click(object sender, EventArgs e)
        {

        }

        private void ColorDialogButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://htmlcolorcodes.com/color-picker/");
        }

        private void FontColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfigOperations.SaveValuesToConfig(FontColorTextBox.Text, "FontColorUpdate");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("If you want edit data please run this program as a administator",
                    "Spotify OBS Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please type a number, not character");
            }
        }

        private void PlayerColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfigOperations.SaveValuesToConfig(PlayerColorTextBox.Text, "PlayerColorUpdate");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("If you want edit data please run this program as a administator",
                    "Spotify OBS Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please type a number, not character");
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfigOperations.SaveValuesToConfig(TitleTextBox.Text, "FontSizeTitleUpdate");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("If you want edit data please run this program as a administator",
                    "Spotify OBS Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please type a number, not character");
            }
        }

        private void ArtistsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfigOperations.SaveValuesToConfig(ArtistsTextBox.Text, "FontSizeArtistsUpdate");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("If you want edit data please run this program as a administator",
                    "Spotify OBS Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please type a number, not character");
            }
        }

        //Check Update Button
        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            GetLatestVersion.CheckVersion();
        }
    }
}
