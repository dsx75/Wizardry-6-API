using System;
using System.Text;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyCharacter : ICharacter
    {
        private byte[] _binData;
        private string _name;

        internal MyCharacter(byte[] binData)
        {
            // TODO check if size of the hex chunk is correct (432)
            _binData = binData;

            // Character name (7 letters)
            _name = "";
            for (int i = 0; i < 7; i++)
            {
                _name += Convert.ToChar(_binData[i]);
            }
        }

        public byte[] BinData
        {
            get
            {
                return _binData;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // TODO add check - only English alphabet letters are allowed
                // TODO check for min required lenght 1
                // TODO check for max allowed lenght 7

                // Convert to uppercase
                _name = value.ToUpper();

                // Fill with NUL (ASCII 0) if it's shorter than 7 letters
                char c = '\x0';
                _name = _name.PadRight(7, c);

                // Update binary data
                byte[] binNew = Encoding.ASCII.GetBytes(_name);
                Array.Copy(binNew, 0, _binData, 0, 7);
            }
        }

        public Race Race { get; set; }

        public Sex Sex { get; set; }

        public Profession Profession { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Piety { get; set; }

        public int Vitality { get; set; }

        public int Dexterity { get; set; }

        public int Speed { get; set; }

        public int Personality { get; set; }

        public int Karma { get; set; }

    }
}
