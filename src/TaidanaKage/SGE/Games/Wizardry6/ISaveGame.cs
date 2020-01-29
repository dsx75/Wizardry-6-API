using System;
using System.Collections.Generic;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Wizardy 6 saved game file
    /// </summary>
    public interface ISaveGame
    {

        /// <summary>
        /// Player characters (party)
        /// </summary>
        List<ICharacter> Characters { get; set; }

    }
}
