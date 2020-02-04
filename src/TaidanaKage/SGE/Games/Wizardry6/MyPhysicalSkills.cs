using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyPhysicalSkills : IPhysicalSkills
    {

        internal MyPhysicalSkills(byte[] binData)
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

        public byte Swimming
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

        public byte Scouting
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

        public byte Music
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

        public byte Oratory
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

        public byte Legerdemain
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

        public byte Skulduggery
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

        public byte Ninjutsu
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

    }
}
