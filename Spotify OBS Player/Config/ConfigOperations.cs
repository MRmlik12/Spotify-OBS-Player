﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IniParser;
using IniParser.Model;

namespace Spotify_OBS_Player.Config
{
    public class ConfigOperations
    {
        readonly string configName = "config.conf";

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
            var file = File.Create(configName);
            file.Close();
            File.WriteAllLines(configName, Lines());
        }

        private List<string> Lines()
        {
            List<string> lines = new List<string> { };
            lines.Add("[Config]");
            lines.Add("update_time=10");
            lines.Add("version=1.0");
            return lines;
        }

        public int LoadValuesFromConfig()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(configName);
            return Convert.ToInt32(data["Config"]["update_time"]);
        }

        public void SaveValuesToConfig(int updateTime)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(configName);
            data["Config"]["update_time"] = updateTime.ToString();
            parser.WriteFile(configName, data);
        }
    }
}
