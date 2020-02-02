using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Global Constants
    /// </summary>
    static class Constants
    {
        public const int MinAge = 6570; // 18 years
        public const int MaxAge = 364635; // 999 years (only 3 digits are shown on the character screen)
        public const int DaysInYear = 365;

        public const int MinXp = 0;
        public const int MaxXp = Int32.MaxValue;

        public const short MinLevel = 1;
        public const short MaxLevel = Int16.MaxValue;

        public const short MinRebirths = 1;
        public const short MaxRebirths = Int16.MaxValue;
    }
}
