using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyResistances : IResistances
    {
        private const byte MinResistanceValue = 0;
        private const byte MaxResistanceValue = 100;

        internal MyResistances(byte[] binData)
        {
            BinData = binData;
        }

        public byte[] BinData { get; }

        public byte MinAllowedValue
        {
            get
            {
                return MinResistanceValue;
            }
        }

        public byte MaxAllowedValue
        {
            get
            {
                return MaxResistanceValue;
            }
        }

        public byte Special
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

        public byte Fire
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

        public byte Light
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

        public byte Cold
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

        public byte Paralysis
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

        public byte Air
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

        public byte Poison
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

        public byte Missiles
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

        public byte Acid
        {
            get
            {
                return BinData[8];
            }
            set
            {
                SetValue(8, value);
            }
        }

        public byte Hypnosis
        {
            get
            {
                return BinData[9];
            }
            set
            {
                SetValue(9, value);
            }
        }

        public byte Psionic
        {
            get
            {
                return BinData[10];
            }
            set
            {
                SetValue(10, value);
            }
        }

        public byte Lifeforce
        {
            get
            {
                return BinData[11];
            }
            set
            {
                SetValue(11, value);
            }
        }

        public byte Magic
        {
            get
            {
                return BinData[12];
            }
            set
            {
                SetValue(12, value);
            }
        }

        public byte Death
        {
            get
            {
                return BinData[13];
            }
            set
            {
                SetValue(13, value);
            }
        }

        private void SetValue(int offset, byte value)
        {
            byte b = value;
            if (b < MinResistanceValue)
            {
                b = MinResistanceValue;
            }
            if (b > MaxResistanceValue)
            {
                b = MaxResistanceValue;
            }
            BinData[offset] = b;
        }

    }
}
