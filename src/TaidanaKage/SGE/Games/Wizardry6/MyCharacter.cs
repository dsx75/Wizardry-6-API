using System;
using System.Text;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyCharacter : ICharacter
    {
        private byte[] _binData;
        private string _name;
        private int _currentHitPoints;
        private int _totalHitPoints;
        private int _currentStamina;
        private int _totalStamina;

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

            // Current hit points
            _currentHitPoints = _binData[24] + (256 * _binData[25]);

            // Total hit points
            _totalHitPoints = _binData[26] + (256 * _binData[27]);

            // Current stamina
            _currentStamina = _binData[28] + (256 * _binData[29]);

            // Total stamina
            _totalStamina = _binData[30] + (256 * _binData[31]);
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

        public int CurrentHitPoints
        {
            get
            {
                return _currentHitPoints;
            }
            set
            {
                // TODO add checks for min/max allowed values
                // TODO update binary data

                _currentHitPoints = value;
            }
        }

        public int TotalHitPoints
        {
            get
            {
                return _totalHitPoints;
            }
            set
            {
                // TODO add checks for min/max allowed values
                // TODO update binary data

                _totalHitPoints = value;
            }
        }

        public int CurrentStamina
        {
            get
            {
                return _currentStamina;
            }
            set
            {
                // TODO add checks for min/max allowed values
                // TODO update binary data

                _currentStamina = value;
            }
        }

        public int TotalStamina
        {
            get
            {
                return _totalStamina;
            }
            set
            {
                // TODO add checks for min/max allowed values
                // TODO update binary data

                _totalStamina = value;
            }
        }

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
