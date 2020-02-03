namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Character's Skills
    /// </summary>
    public interface ISkills
    {

        /// <summary>
        /// Character's skills represented as an array of bytes
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// Weaponry skills
        /// </summary>
        IWeaponrySkills Weaponry { get; }

        /// <summary>
        /// Physical skills
        /// </summary>
        IPhysicalSkills Physical { get; }

        /// <summary>
        ///  Personal skills
        /// </summary>
        IPersonalSkills Personal { get; }

        /// <summary>
        /// Academia skills
        /// </summary>
        IAcademiaSkills Academia { get; }

    }
}
