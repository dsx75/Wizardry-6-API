using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyAcademiaSkills : IAcademiaSkills
    {

        internal MyAcademiaSkills(byte[] binData)
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

        public byte Artifacts
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

        public byte Mythology
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

        public byte Scribe
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

        public byte Alchemy
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

        public byte Theology
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

        public byte Theosophy
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

        public byte Thaumaturgy
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

        public byte Kirijutsu
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
