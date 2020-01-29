using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Wizardry 6 player character
    /// </summary>
    public interface ICharacter
    {

        /// <summary>
        /// This character represented as an array of bytes.
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// Name
        /// Min. required letters: 1
        /// Max. allowed letters: 7
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Race
        /// </summary>
        Race Race { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        Sex Sex { get; set; }

        /// <summary>
        /// Profession
        /// </summary>
        Profession Profession { get; set; }

        /// <summary>
        /// Current hit points
        /// </summary>
        int CurrentHitPoints { get; set; }

        /// <summary>
        /// Max hit points
        /// </summary>
        int TotalHitPoints { get; set; }

        /// <summary>
        /// Current stamina
        /// </summary>
        int CurrentStamina { get; set; }

        /// <summary>
        /// Max stamina
        /// </summary>
        int TotalStamina { get; set; }

        /// <summary>
        /// Strength (STR) 
        /// Allowed values: 0 - 18
        /// </summary>
        int Strength { get; set; }

        /// <summary>
        /// Intelligence (INT) 
        /// Allowed values: 0 - 18
        /// </summary>
        int Intelligence { get; set; }

        /// <summary>
        /// Piety (PIE) 
        /// Allowed values: 0 - 18
        /// </summary>
        int Piety { get; set; }

        /// <summary>
        /// Vitality (VIT) 
        /// Allowed values: 0 - 18
        /// </summary>
        int Vitality { get; set; }

        /// <summary>
        /// Dexterity (DEX) 
        /// Allowed values: 0 - 18
        /// </summary>
        int Dexterity { get; set; }

        /// <summary>
        /// Speed (SPD) 
        /// Allowed values: 0 - 18
        /// </summary>
        int Speed { get; set; }

        /// <summary>
        /// Personality (PER) 
        /// Allowed values: 0 - 18
        /// </summary>
        int Personality { get; set; }

        /// <summary>
        /// Karma (KAR) 
        /// Allowed values: 0 - 18
        /// </summary>
        int Karma { get; set; }

    }
}
