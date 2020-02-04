namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Character's Academia Skills
    /// </summary>
    public interface IAcademiaSkills
    {

        /// <summary>
        /// Character's academia skills represented as an array of bytes
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// Artifacts skill
        /// </summary>
        public byte Artifacts { get; set; }

        /// <summary>
        /// Mythology skill
        /// </summary>
        public byte Mythology { get; set; }

        /// <summary>
        /// Scribe skill
        /// </summary>
        public byte Scribe { get; set; }

        /// <summary>
        /// Alchemy skill
        /// </summary>
        public byte Alchemy { get; set; }

        /// <summary>
        /// Theology skill
        /// </summary>
        public byte Theology { get; set; }

        /// <summary>
        /// Theosophy skill
        /// </summary>
        public byte Theosophy { get; set; }

        /// <summary>
        /// Thaumaturgy skill
        /// </summary>
        public byte Thaumaturgy { get; set; }

        /// <summary>
        /// Kirijutsu skill
        /// </summary>
        public byte Kirijutsu { get; set; }

    }
}
