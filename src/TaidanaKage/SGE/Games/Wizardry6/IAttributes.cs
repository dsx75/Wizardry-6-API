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
        /// </summary>
        byte Strength { get; set; }

        /// <summary>
        /// Intelligence (INT) 
        /// </summary>
        byte Intelligence { get; set; }

        /// <summary>
        /// Piety (PIE) 
        /// </summary>
        byte Piety { get; set; }

        /// <summary>
        /// Vitality (VIT) 
        /// </summary>
        byte Vitality { get; set; }

        /// <summary>
        /// Dexterity (DEX) 
        /// </summary>
        byte Dexterity { get; set; }

        /// <summary>
        /// Speed (SPD) 
        /// </summary>
        byte Speed { get; set; }

        /// <summary>
        /// Personality (PER) 
        /// </summary>
        byte Personality { get; set; }

        /// <summary>
        /// Karma (KAR) 
        /// </summary>
        byte Karma { get; set; }

    }
}
