﻿using Baraka.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraka.Data
{
    public class MySettings
    {
        private string _path;


        // With temporary (debug) default values

        #region Settings
        // General
        public bool Startup { get; set; } = false;
        public Language Language { get; set; } = Language.FRENCH;

        // Appearance
        public bool ShowWelcomeWindow { get; set; } = true;
        public bool DisplayScrollBar { get; set; } = true;

        // Reading
        public int DefaultSurahIndex { get; set; } = 0;
        public int DefaultCheikhIndex { get; set; } = 0;
        public bool AutoScrollQuran { get; set; } = false;
        public bool AutoNextSurah { get; set; } = false;
        public bool AutoReloadLastSurah { get; set; } = true;

        #endregion


        public MySettings(string path)
        {
            _path = path;
        }
        public void Save()
        {
            // use _path
        }
    }
}