using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyWeaponrySkills : IWeaponrySkills
    {

        internal MyWeaponrySkills(byte[] binData)
        {
            BinData = binData;
        }

        public byte[] BinData { get; }

        private void SetValue(int offset, byte value)
        {
            byte b = value;
            if (b < Constants.MinSkillValue)
            {
                b = Constants.MinSkillValue;
            }
            if (b > Constants.MaxSkillValue)
            {
                b = Constants.MaxSkillValue;
            }
            BinData[offset] = b;
        }

        public byte WandAndDagger
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

        public byte Sword
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

        public byte Axe
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

        public byte MaceAndFlail
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

        public byte PoleAndStaff
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

        public byte Throwing
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

        public byte Sling
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

        public byte Bows
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

        public byte Shield
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

        public byte HandsAndFeet
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

    }
}
