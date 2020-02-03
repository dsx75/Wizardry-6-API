using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyAttributes : IAttributes
    {

        internal MyAttributes(byte[] binData)
        {
            BinData = binData;
        }

        public byte[] BinData { get; }

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
            BinData[offset] = b;
        }

        public byte Strength
        {
            get
            {
                return BinData[0];
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
                return BinData[1];
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
                return BinData[2];
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
                return BinData[3];
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
                return BinData[4];
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
                return BinData[5];
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
                return BinData[6];
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
                return BinData[7];
            }
            set
            {
                SetValue(7, value);
            }
        }

    }
}
