﻿using BeatSaberMarkupLanguage.Settings;

namespace TransparentWall.Settings.UI
{
    internal class SettingsUI
    {
        public static bool created = false;

        public static void CreateMenu()
        {
            if (!created)
            {
                BSMLSettings.instance.AddSettingsMenu("Transparent Walls", "TransparentWall.Settings.UI.Views.mainsettings.bsml", MainSettings.instance);
                created = true;
            }
        }

        public static void RemoveMenu()
        {
            if (created)
            {
                BSMLSettings.instance.RemoveSettingsMenu(MainSettings.instance);
                created = false;
            }
        }
    }
}