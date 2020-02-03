namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Character's Skills
    /// </summary>
    public interface ISkills
    {

        /// <summary>
        /// Character skills represented as an array of bytes
        /// </summary>
        byte[] BinData { get; }

    }
}
