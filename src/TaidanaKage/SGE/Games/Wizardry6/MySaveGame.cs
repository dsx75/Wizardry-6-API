using System;
using System.Collections.Generic;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MySaveGame : ISaveGame
    {
        private readonly int offsetPartySize = 49854; // C2BE
        private readonly int offsetCharacter1 = 49856; // C2C0
        private readonly int binDataCharacterLenght = 432;

        private byte[] _binData;

        internal MySaveGame(byte[] binData)
        {
            _binData = binData;

            PartySize = _binData[offsetPartySize];

            int offset = offsetCharacter1;
            List<ICharacter> characters = new List<ICharacter>();
            for (int ch = 1; ch <= PartySize; ch++)
            {
                byte[] binDataCharacter = new byte[binDataCharacterLenght];
                Array.Copy(_binData, offset, binDataCharacter, 0, binDataCharacterLenght);
                ICharacter character = new MyCharacter(binDataCharacter);
                characters.Add(character);
                offset += binDataCharacterLenght;
            }
            Characters = characters;
        }

        public byte PartySize { get; }

        public List<ICharacter> Characters { get; }

        public byte[] BinData
        {
            get
            {
                // Update binary data for each Character (in case they've been modified)
                int offset = offsetCharacter1;
                for (int i = 0; i < 6; i++)
                {
                    ICharacter character = Characters[i];
                    Array.Copy(character.BinData, 0, _binData, offset, binDataCharacterLenght);
                    offset += binDataCharacterLenght;
                }

                return _binData;
            }
        }

    }
}
