namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Character's Physical Skills
    /// </summary>
    public interface IPhysicalSkills
    {

        /// <summary>
        /// Character's physical skills represented as an array of bytes
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// Swimming skill (secret)
        /// </summary>
        public byte Swimming { get; set; }

        /// <summary>
        /// Scouting skill
        /// </summary>
        public byte Scouting { get; set; }

        /// <summary>
        /// Music skill
        /// </summary>
        public byte Music { get; set; }

        /// <summary>
        /// Oratory skill
        /// </summary>
        public byte Oratory { get; set; }

        /// <summary>
        /// Legerdemain skill
        /// </summary>
        public byte Legerdemain { get; set; }

        /// <summary>
        /// Skulduggery skill
        /// </summary>
        public byte Skulduggery { get; set; }

        /// <summary>
        /// Ninjutsu skill
        /// </summary>
        public byte Ninjutsu { get; set; }

    }
}
