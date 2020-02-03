using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Global Constants
    /// </summary>
    static class Constants
    {
        /// <summary>
        /// Absolute offset for the Character's Spell Points section.
        /// </summary>
        public const int OffsetSpellPoints = 40;

        /// <summary>
        /// Length (in bytes) of the Character's Spell Points section.
        /// </summary>
        public const int LenghtSpellPoints = 24;

        public const int Pow8 = 256; // 2^8
        public const int Pow16 = 65536; // 2^16
        public const int Pow24 = 16777216; // 2^24

        public const int MinNameLength = 1;
        public const int MaxNameLength = 7;

        public const int MinAge = 6570; // 18 years
        public const int MaxAge = 364635; // 999 years (only 3 digits are shown on the character screen)
        public const int DaysInYear = 365;

        public const int MinXp = 0;
        public const int MaxXp = Int32.MaxValue;

        public const int MinKills = 0;
        public const int MaxKills = Int32.MaxValue;

        public const int MinGold = 0;
        public const int MaxGold = Int32.MaxValue; // Only the last 7 digits are displayed on the character screen

        public const short MinHitPoints = 0;
        public const short MaxHitPoints = Int16.MaxValue; // Only the last 4 digits are dipslayed on the character screen

        public const short MinStamina = 0;
        public const short MaxStamina = Int16.MaxValue;

        public const short MinCarryingCapacity = 0;
        public const short MaxCarryingCapacity = Int16.MaxValue; // Only the first 3 digits are displayed on the character screen

        public const short MinLevel = 1;
        public const short MaxLevel = Int16.MaxValue;

        public const short MinRebirths = 1;
        public const short MaxRebirths = Int16.MaxValue;

        public const short MinSpellPoints = 0;
        public const short MaxSpellPoints = Int16.MaxValue;
    }
}
