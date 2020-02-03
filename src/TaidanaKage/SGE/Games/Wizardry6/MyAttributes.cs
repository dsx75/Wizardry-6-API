using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyAttributes : IAttributes
    {
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

        private void SetValue(int offset, byte value)
        {
            byte b = value;
            if (b < Constants.MinAttributeValue)
            {
                b = Constants.MinAttributeValue;
            }
            if (b > Constants.MaxAttributeValue)
            {
                b = Constants.MaxAttributeValue;
            }
            _binData[offset] = b;
        }

        public byte Strength
        {
            get
            {
                return _binData[0];
            }
            set
            {
                SetValue(0, value);
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
                SetValue(1, value);
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
                SetValue(2, value);
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
                SetValue(3, value);
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
                SetValue(4, value);
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
                SetValue(5, value);
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
                SetValue(6, value);
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
                SetValue(7, value);
            }
        }

    }
}
