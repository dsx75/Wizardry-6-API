using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    class MyPersonalSkills : IPersonalSkills
    {

        internal MyPersonalSkills(byte[] binData)
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

        public byte Defense
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

        public byte Speed
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

        public byte Movement
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

        public byte Aim
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

        public byte Power
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

    }
}
