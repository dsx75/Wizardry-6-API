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
        /// Age (in days)
        /// </summary>
        int Age { get; set; }

        /// <summary>
        /// Age (in years)
        /// </summary>
        int AgeInYears { get; set; }

        /// <summary>
        /// Experience (EXP)
        /// </summary>
        int Experience { get; set; }

        /// <summary>
        /// Monster Kill Statistic (MKS)
        /// </summary>
        int Kills { get; set; }

        /// <summary>
        /// Gold Pieces (GP)
        /// </summary>
        int GoldPieces { get; set; }

        /// <summary>
        /// Current Hit Points (HP)
        /// </summary>
        short CurrentHitPoints { get; set; }

        /// <summary>
        /// Total Hit Points (HP)
        /// </summary>
        short TotalHitPoints { get; set; }

        /// <summary>
        /// Current Stamina (STM)
        /// </summary>
        short CurrentStamina { get; set; }

        /// <summary>
        /// Total Stamina (STM)
        /// </summary>
        short TotalStamina { get; set; }

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
        /// 8 attributes (statistics) of this character.
        /// </summary>
        IAttributes Attributes { get; }

    }
}
