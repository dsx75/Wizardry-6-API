namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Character's Weaponry Skills
    /// </summary>
    public interface IWeaponrySkills
    {

        /// <summary>
        /// Character's weaponry skills represented as an array of bytes
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// Wand & Dagger skill
        /// </summary>
        public byte WandAndDagger { get; set; }

        /// <summary>
        /// Sword skill
        /// </summary>
        public byte Sword { get; set; }

        /// <summary>
        /// Axe skill
        /// </summary>
        public byte Axe { get; set; }

        /// <summary>
        /// Mace & Flail skill
        /// </summary>
        public byte MaceAndFlail { get; set; }

        /// <summary>
        /// Pole & Staff skills
        /// </summary>
        public byte PoleAndStaff { get; set; }

        /// <summary>
        /// Throwing skill
        /// </summary>
        public byte Throwing { get; set; }

        /// <summary>
        /// Sling skill
        /// </summary>
        public byte Sling { get; set; }

        /// <summary>
        /// Bows skills
        /// </summary>
        public byte Bows { get; set; }

        /// <summary>
        /// Shield skill
        /// </summary>
        public byte Shield { get; set; }

        /// <summary>
        /// Hands & feet
        /// </summary>
        public byte HandsAndFeet { get; set; }

    }
}
