﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updater.URL
{
    public class RootObject
    {
        public string version { get; set; }
        public int version_code { get; set; }
        public string download_url { get; set; }
        public string changes { get; set; }
    }
}
