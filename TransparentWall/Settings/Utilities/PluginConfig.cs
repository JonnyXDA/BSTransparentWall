﻿using System.Collections.Generic;

namespace TransparentWall.Settings.Utilities
{
    public class PluginConfig
    {
        public bool RegenerateConfig = true;

        public bool HMD = false;
        public bool DisableInLIVCamera = false;

        public Dictionary<string, object> Logging = new Dictionary<string, object>()
        {
            { "ShowCallSource", false },
        };
    }
}
