using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IniParser;
using IniParser.Model;
using System.Windows.Forms;

namespace Spotify_OBS_Player.Config
{
    public class ConfigOperations
    {
        readonly string configName = "config.conf";
        public bool create = true;

        public void CheckConfig()
        {
            bool file = File.Exists(configName);

            if (file == false)
            {
                CreateConfig();
            }
        }

        private void CreateConfig()
        {
            try
            {
                var file = File.Create(configName);
                file.Close();
                File.WriteAllLines(configName, Lines());
            }
            catch (Exception)
            {
                MessageBox.Show("Please run again this program with administrator privileges",
                    "Spotify OBS Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                create = false;
            }
        }

        private List<string> Lines()
        {
            List<string> lines = new List<string> { };
            lines.Add("[Config]");
            lines.Add("update_time=10");
            lines.Add("font_size_title=14");
            lines.Add("font_size_artists=10");
            lines.Add("font_color=#FFFFFF");
            lines.Add("player_color=#292828");
            lines.Add("version=2.0");
            return lines;
        }

        public string[] LoadValuesFromConfig()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(configName);
            if (data["Config"]["version"].ToString() == "1.0")
                UpdateConfigFile();

            string[] values = {
                data["Config"]["update_time"],
                data["Config"]["font_color"],
                data["Config"]["player_color"],
                data["Config"]["font_size_title"],
                data["Config"]["font_size_artists"]
            };

            return values;
        }

        public void SaveValuesToConfig(string value, string ItemName = "UpdateTime")
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(configName);
            if (ItemName == "UpdateTime")
                data["Config"]["update_time"] = value;
            else if (ItemName == "FontColorUpdate")
                data["Config"]["font_color"] = value;
            else if (ItemName == "PlayerColorUpdate")
                data["Config"]["player_color"] = value;
            else if (ItemName == "FontSizeTitleUpdate")
                data["Config"]["font_size_title"] = value;
            else if (ItemName == "FontSizeArtistsUpdate")
                data["Config"]["font_size_artists"] = value;
            parser.WriteFile(configName, data);
        }

        private void UpdateConfigFile()
        {
            File.Delete(configName);
            var file = File.Create(configName);
            File.WriteAllLines(configName, Lines());
        }
    }
}
