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

namespace Spotify_OBS_Player
{
    public partial class Form1 : MaterialForm
    {
        Config.ConfigOperations ConfigOperations = new Config.ConfigOperations();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigOperations.CheckConfig();
            UpdateTimeField.Text = ConfigOperations.LoadValuesFromConfig().ToString();
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
                ConfigOperations.SaveValuesToConfig(Convert.ToInt32(UpdateTimeField.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please type a number, not character");
            }
        }
    }
}
