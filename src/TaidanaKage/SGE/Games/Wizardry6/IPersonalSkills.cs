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

    }
}
