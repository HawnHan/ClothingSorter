﻿using Verse;

namespace ClothingSorter
{
    /// <summary>
    /// Definition of the settings for the mod
    /// </summary>
    internal class ClothingSorterSettings : ModSettings
    {
        public bool SortByLayer = true;
        public bool SortByTech = false;
        public string TechSortSetting = ClothingSorterMod.TechSortSettingOptions[0];
        public bool ArmoredSeparate = true;
        public float ArmorRating = 0.1f;
        public bool PsychicSeparate = true;

        /// <summary>
        /// Saving and loading the values
        /// </summary>
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref SortByLayer, "SortByLayer", true, false);
            Scribe_Values.Look(ref SortByTech, "SortByTech", false, false);
            Scribe_Values.Look(ref TechSortSetting, "TechSortSetting", ClothingSorterMod.TechSortSettingOptions[0], false);
            Scribe_Values.Look(ref ArmoredSeparate, "ArmoredSeparate", true, false);
            Scribe_Values.Look(ref ArmorRating, "ArmorRating", 0.1f, false);
            Scribe_Values.Look(ref PsychicSeparate, "PsychicSeparate", true, false);
        }
    }
}