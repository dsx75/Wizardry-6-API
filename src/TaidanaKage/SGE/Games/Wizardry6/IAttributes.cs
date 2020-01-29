using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// 8 attributes (statistics) of a player character
    /// </summary>
    public interface IAttributes
    {

        /// <summary>
        /// Character attributes represented as an array of bytes
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// Strength (STR) 
        /// Allowed values: 0 - 18
        /// </summary>
        byte Strength { get; set; }

        /// <summary>
        /// Intelligence (INT) 
        /// Allowed values: 0 - 18
        /// </summary>
        byte Intelligence { get; set; }

        /// <summary>
        /// Piety (PIE) 
        /// Allowed values: 0 - 18
        /// </summary>
        byte Piety { get; set; }

        /// <summary>
        /// Vitality (VIT) 
        /// Allowed values: 0 - 18
        /// </summary>
        byte Vitality { get; set; }

        /// <summary>
        /// Dexterity (DEX) 
        /// Allowed values: 0 - 18
        /// </summary>
        byte Dexterity { get; set; }

        /// <summary>
        /// Speed (SPD) 
        /// Allowed values: 0 - 18
        /// </summary>
        byte Speed { get; set; }

        /// <summary>
        /// Personality (PER) 
        /// Allowed values: 0 - 18
        /// </summary>
        byte Personality { get; set; }

        /// <summary>
        /// Karma (KAR) 
        /// Allowed values: 0 - 18
        /// </summary>
        byte Karma { get; set; }

    }
}
