using System;
using System.Collections.Generic;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MySaveGame : ISaveGame
    {

        internal MySaveGame(List<ICharacter> characters)
        {
            // TODO check if the list if not null
            Characters = characters;
        }

        public List<ICharacter> Characters { get; set; }

    }
}
