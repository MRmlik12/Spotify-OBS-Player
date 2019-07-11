using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Spotify_OBS_Player.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RepositoryButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MRmlik12/Spotify-OBS-Player");
        }
    }
}
