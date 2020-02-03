namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Character's Spell Points
    /// </summary>
    public interface ISpellPoints
    {

        /// <summary>
        /// Character's Spell Points represented as an array of bytes.
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// Current Spell Points - Fire Realm
        /// </summary>
        short CurrentFire { get; set; }

        /// <summary>
        /// Total Spell Points - Fire Realm
        /// </summary>
        short TotalFire { get; set; }

        /// <summary>
        /// Current Spell Points - Water Realm
        /// </summary>
        short CurrentWater { get; set; }

        /// <summary>
        /// Total Spell Points - Water Realm
        /// </summary>
        short TotalWater { get; set; }

        /// <summary>
        /// Current Spell Points - Air Realm
        /// </summary>
        short CurrentAir { get; set; }

        /// <summary>
        /// Total Spell Points - Air Realm
        /// </summary>
        short TotalAir { get; set; }

        /// <summary>
        /// Current Spell Points - Earth Realm
        /// </summary>
        short CurrentEarth { get; set; }

        /// <summary>
        /// Total Spell Points - Earth Realm
        /// </summary>
        short TotalEarth { get; set; }

        /// <summary>
        /// Current Spell Points - Mental Realm
        /// </summary>
        short CurrentMental { get; set; }

        /// <summary>
        /// Total Spell Points - Mental Realm
        /// </summary>
        short TotalMental { get; set; }

        /// <summary>
        /// Current Spell Points - Magic Realm
        /// </summary>
        short CurrentMagic { get; set; }

        /// <summary>
        /// Total Spell Points - Magic Realm
        /// </summary>
        short TotalMagic { get; set; }

    }
}
