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

    }
}
