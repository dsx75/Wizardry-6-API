using System;
using System.Collections.Generic;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Saved game file
    /// </summary>
    public interface ISaveGame
    {

        /// <summary>
        /// Player characters (party)
        /// </summary>
        List<ICharacter> Characters { get; }

        /// <summary>
        /// The whole save game file represented as an array of bytes.
        /// </summary>
        byte[] BinData { get; }

    }
}
