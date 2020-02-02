using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Player character
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
        /// Level
        /// </summary>
        short Level { get; set; }

        /// <summary>
        /// Rebirths
        /// </summary>
        short Rebirths { get; set; }

        /// <summary>
        /// Current hit points
        /// Allowed values: 0 - 9999
        /// </summary>
        ushort CurrentHitPoints { get; set; }

        /// <summary>
        /// Max hit points
        /// Allowed values: 0 - 9999
        /// </summary>
        ushort TotalHitPoints { get; set; }

        /// <summary>
        /// Current stamina
        /// Allowed values: 0 - 9999
        /// </summary>
        ushort CurrentStamina { get; set; }

        /// <summary>
        /// Max stamina
        /// Allowed values: 0 - 9999
        /// </summary>
        ushort TotalStamina { get; set; }

        /// <summary>
        /// 8 attributes (statistics) of this character.
        /// </summary>
        IAttributes Attributes { get; }

    }
}
