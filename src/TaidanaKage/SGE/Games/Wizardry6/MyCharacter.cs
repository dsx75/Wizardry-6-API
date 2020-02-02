using System;
using System.Text;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyCharacter : ICharacter
    {
        private byte[] _binData;
        private string _name;
        private ushort _currentHitPoints;
        private ushort _totalHitPoints;
        private ushort _currentStamina;
        private ushort _totalStamina;
        private IAttributes _attributes;

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
            _currentHitPoints = (ushort)(_binData[24] + (256 * _binData[25]));

            // Total hit points
            _totalHitPoints = (ushort)(_binData[26] + (256 * _binData[27]));

            // Current stamina
            _currentStamina = (ushort)(_binData[28] + (256 * _binData[29]));

            // Total stamina
            _totalStamina = (ushort)(_binData[30] + (256 * _binData[31]));

            // Attributes
            byte[] binDataAttributes = new byte[8];
            Array.Copy(_binData, 300, binDataAttributes, 0, 8);
            _attributes = new MyAttributes(binDataAttributes);
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

        public int Age
        {
            get
            {
                return (int)(_binData[8] + (256 * _binData[9]) + (65536 * _binData[10]) + (16777216 * _binData[11]));
            }
            set
            {
                int age = value;
                if (age < Constants.MinAge)
                {
                    age = Constants.MinAge;
                }
                if (age > Constants.MaxAge)
                {
                    age = Constants.MaxAge;
                }
                byte[] b = BitConverter.GetBytes(age);
                _binData[8] = b[0];
                _binData[9] = b[1];
                _binData[10] = b[2];
                _binData[11] = b[3];
            }
        }

        public int AgeInYears
        {
            get
            {
                return Age / Constants.DaysInYear;
            }
            set
            {
                int age = value * Constants.DaysInYear;
                Age = age;
            }
        }

        public Race Race { get; set; }

        public Sex Sex { get; set; }

        public Profession Profession { get; set; }

        public ushort CurrentHitPoints
        {
            get
            {
                return _currentHitPoints;
            }
            set
            {
                // TODO add checks for min/max allowed values

                _currentHitPoints = value;

                // Update binary data
                byte[] b = BitConverter.GetBytes(_currentHitPoints);
                _binData[24] = b[0];
                _binData[25] = b[1];
            }
        }

        public ushort TotalHitPoints
        {
            get
            {
                return _totalHitPoints;
            }
            set
            {
                // TODO add checks for min/max allowed values

                _totalHitPoints = value;

                // Update binary data
                byte[] b = BitConverter.GetBytes(_totalHitPoints);
                _binData[26] = b[0];
                _binData[27] = b[1];
            }
        }

        public ushort CurrentStamina
        {
            get
            {
                return _currentStamina;
            }
            set
            {
                // TODO add checks for min/max allowed values

                _currentStamina = value;

                // Update binary data
                byte[] b = BitConverter.GetBytes(_currentStamina);
                _binData[28] = b[0];
                _binData[29] = b[1];
            }
        }

        public ushort TotalStamina
        {
            get
            {
                return _totalStamina;
            }
            set
            {
                // TODO add checks for min/max allowed values

                _totalStamina = value;

                // Update binary data
                byte[] b = BitConverter.GetBytes(_totalStamina);
                _binData[30] = b[0];
                _binData[31] = b[1];
            }
        }

        public IAttributes Attributes
        {
            get
            {
                return _attributes;
            }
        }

        public short Level
        {
            get
            {
                return (short)(_binData[36] + (256 * _binData[37]));
            }
            set
            {
                short level = value;
                if (level < Constants.MinLevel)
                {
                    level = Constants.MinLevel;
                }
                if (level > Constants.MaxLevel)
                {
                    level = Constants.MaxLevel;
                }
                byte[] b = BitConverter.GetBytes(level);
                _binData[36] = b[0];
                _binData[37] = b[1];
            }
        }

        public short Rebirths
        {
            get
            {
                return (short)(_binData[38] + (256 * _binData[39]));
            }
            set
            {
                short rebirths = value;
                if (rebirths < Constants.MinRebirths)
                {
                    rebirths = Constants.MinRebirths;
                }
                if (rebirths > Constants.MaxRebirths)
                {
                    rebirths = Constants.MaxRebirths;
                }
                byte[] b = BitConverter.GetBytes(rebirths);
                _binData[38] = b[0];
                _binData[39] = b[1];
            }
        }

    }
}
