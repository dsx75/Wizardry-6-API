using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MySpellPoints : ISpellPoints
    {

        internal MySpellPoints(byte[] binData)
        {
            BinData = binData;
        }

        public byte[] BinData { get; }

        private short GetValue(int offsetLowerByte, int offsetUpperByte)
        {
            return (short)(BinData[offsetLowerByte] + (Constants.Pow8 * BinData[offsetUpperByte]));
        }

        private short CheckValue(short value)
        {
            short sp = value;
            if (sp < Constants.MinSpellPoints)
            {
                sp = Constants.MinSpellPoints;
            }
            if (sp > Constants.MaxSpellPoints)
            {
                sp = Constants.MaxSpellPoints;
            }
            return sp;
        }

        private void SetValue(int offsetLowerByte, int offsetUpperByte, short value)
        {
            byte[] b = BitConverter.GetBytes(value);
            BinData[offsetLowerByte] = b[0];
            BinData[offsetUpperByte] = b[1];
        }

        public short CurrentFire
        {
            get
            {
                return GetValue(0, 1);
            }
            set
            {
                short sp = CheckValue(value);
                if (sp > TotalFire)
                {
                    sp = TotalFire;
                }
                SetValue(0, 1, sp);
            }
        }

        public short TotalFire
        {
            get
            {
                return GetValue(2, 3);
            }
            set
            {
                short sp = CheckValue(value);
                SetValue(2, 3, sp);
            }
        }

        public short CurrentWater
        {
            get
            {
                return GetValue(4, 5);
            }
            set
            {
                short sp = CheckValue(value);
                if (sp > TotalWater)
                {
                    sp = TotalWater;
                }
                SetValue(4, 5, sp);
            }
        }

        public short TotalWater
        {
            get
            {
                return GetValue(6, 7);
            }
            set
            {
                short sp = CheckValue(value);
                SetValue(6, 7, sp);
            }
        }

        public short CurrentAir
        {
            get
            {
                return GetValue(8, 9);
            }
            set
            {
                short sp = CheckValue(value);
                if (sp > TotalAir)
                {
                    sp = TotalAir;
                }
                SetValue(8, 9, sp);
            }
        }

        public short TotalAir
        {
            get
            {
                return GetValue(10, 11);
            }
            set
            {
                short sp = CheckValue(value);
                SetValue(10, 11, sp);
            }
        }

        public short CurrentEarth
        {
            get
            {
                return GetValue(12, 13);
            }
            set
            {
                short sp = CheckValue(value);
                if (sp > TotalEarth)
                {
                    sp = TotalEarth;
                }
                SetValue(12, 13, sp);
            }
        }

        public short TotalEarth
        {
            get
            {
                return GetValue(14, 15);
            }
            set
            {
                short sp = CheckValue(value);
                SetValue(14, 15, sp);
            }
        }

        public short CurrentMental
        {
            get
            {
                return GetValue(16, 17);
            }
            set
            {
                short sp = CheckValue(value);
                if (sp > TotalMental)
                {
                    sp = TotalMental;
                }
                SetValue(16, 17, sp);
            }
        }

        public short TotalMental
        {
            get
            {
                return GetValue(18, 19);
            }
            set
            {
                short sp = CheckValue(value);
                SetValue(18, 19, sp);
            }
        }

        public short CurrentMagic
        {
            get
            {
                return GetValue(20, 21);
            }
            set
            {
                short sp = CheckValue(value);
                if (sp > TotalMagic)
                {
                    sp = TotalMagic;
                }
                SetValue(20, 21, sp);
            }
        }

        public short TotalMagic
        {
            get
            {
                return GetValue(22, 23);
            }
            set
            {
                short sp = CheckValue(value);
                SetValue(22, 23, sp);
            }
        }

    }
}
