using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyAttributes : IAttributes
    {
        private readonly byte maxAllowedValue = 18;

        private byte[] _binData;

        internal MyAttributes(byte[] binData)
        {
            _binData = binData;
        }

        public byte[] BinData
        {
            get
            {
                return _binData;
            }
        }

        public byte Strength
        {
            get
            {
                return _binData[0];
            }
            set
            {
                byte b = value;
                if (b > maxAllowedValue)
                {
                    b = maxAllowedValue;
                }
                _binData[0] = b;
            }
        }

        public byte Intelligence
        {
            get
            {
                return _binData[1];
            }
            set
            {
                byte b = value;
                if (b > maxAllowedValue)
                {
                    b = maxAllowedValue;
                }
                _binData[1] = b;
            }
        }

        public byte Piety
        {
            get
            {
                return _binData[2];
            }
            set
            {
                byte b = value;
                if (b > maxAllowedValue)
                {
                    b = maxAllowedValue;
                }
                _binData[2] = b;
            }
        }

        public byte Vitality
        {
            get
            {
                return _binData[3];
            }
            set
            {
                byte b = value;
                if (b > maxAllowedValue)
                {
                    b = maxAllowedValue;
                }
                _binData[3] = b;
            }
        }

        public byte Dexterity
        {
            get
            {
                return _binData[4];
            }
            set
            {
                byte b = value;
                if (b > maxAllowedValue)
                {
                    b = maxAllowedValue;
                }
                _binData[4] = b;
            }
        }

        public byte Speed
        {
            get
            {
                return _binData[5];
            }
            set
            {
                byte b = value;
                if (b > maxAllowedValue)
                {
                    b = maxAllowedValue;
                }
                _binData[5] = b;
            }
        }

        public byte Personality
        {
            get
            {
                return _binData[6];
            }
            set
            {
                byte b = value;
                if (b > maxAllowedValue)
                {
                    b = maxAllowedValue;
                }
                _binData[6] = b;
            }
        }

        public byte Karma
        {
            get
            {
                return _binData[7];
            }
            set
            {
                byte b = value;
                if (b > maxAllowedValue)
                {
                    b = maxAllowedValue;
                }
                _binData[7] = b;
            }
        }

    }
}
