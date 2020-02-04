namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Character's Personal Skills
    /// </summary>
    public interface IPersonalSkills
    {

        /// <summary>
        /// Character's personal skills represented as an array of bytes
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// Defense skill (secret)
        /// </summary>
        public byte Defense { get; set; }

        /// <summary>
        /// Speed skill (secret)
        /// </summary>
        public byte Speed { get; set; }

        /// <summary>
        /// MOvement skill (secret)
        /// </summary>
        public byte Movement { get; set; }

        /// <summary>
        /// Aim skill (secret)
        /// </summary>
        public byte Aim { get; set; }

        /// <summary>
        /// Power skill (secret)
        /// </summary>
        public byte Power { get; set; }

    }
}
