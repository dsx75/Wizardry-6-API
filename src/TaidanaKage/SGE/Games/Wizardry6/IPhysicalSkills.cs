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

    }
}
