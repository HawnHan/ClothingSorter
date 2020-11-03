﻿using Verse;

namespace ClothingSorter
{
    /// <summary>
    /// Definition of the settings for the mod
    /// </summary>
    internal class ClothingSorterSettings : ModSettings
    {
        public bool ArmoredSeparate = true;
        public float ArmorRating = 0.1f;
        public bool PsychicSeparate = true;

        /// <summary>
        /// Saving and loading the values
        /// </summary>
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref ArmoredSeparate, "ArmoredSeparate", true, false);
            Scribe_Values.Look(ref ArmorRating, "ArmorRating", 0.1f, false);
            Scribe_Values.Look(ref PsychicSeparate, "PsychicSeparate", true, false);
        }
    }
}