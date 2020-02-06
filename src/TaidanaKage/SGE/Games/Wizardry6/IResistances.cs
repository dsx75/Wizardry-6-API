namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Character's resistances
    /// </summary>
    public interface IResistances
    {

        /// <summary>
        /// Character's resistances represented as an array of bytes
        /// </summary>
        byte[] BinData { get; }

        /// <summary>
        /// The lowest value allowed for any resistance.
        /// </summary>
        byte MinAllowedValue { get; }

        /// <summary>
        /// The highest value allowed for any resistance.
        /// </summary>
        byte MaxAllowedValue { get; }

        /// <summary>
        /// Special
        /// </summary>
        byte Special { get; set; }

        /// <summary>
        /// Fire
        /// </summary>
        byte Fire { get; set; }

        /// <summary>
        /// Light
        /// </summary>
        byte Light { get; set; }

        /// <summary>
        /// Cold
        /// </summary>
        byte Cold { get; set; }

        /// <summary>
        /// Paralysis
        /// </summary>
        byte Paralysis { get; set; }

        /// <summary>
        /// Air
        /// </summary>
        byte Air { get; set; }

        /// <summary>
        /// Poison
        /// </summary>
        byte Poison { get; set; }

        /// <summary>
        /// Missiles
        /// </summary>
        byte Missiles { get; set; }

        /// <summary>
        /// Acid
        /// </summary>
        byte Acid { get; set; }

        /// <summary>
        /// Hypnosis
        /// </summary>
        byte Hypnosis { get; set; }

        /// <summary>
        /// Psionic
        /// </summary>
        byte Psionic { get; set; }

        /// <summary>
        /// Lifeforce
        /// </summary>
        byte Lifeforce { get; set; }

        /// <summary>
        /// Magic
        /// </summary>
        byte Magic { get; set; }

        /// <summary>
        /// Death
        /// </summary>
        byte Death { get; set; }

    }
}
