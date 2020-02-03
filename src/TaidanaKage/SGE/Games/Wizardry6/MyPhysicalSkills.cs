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

    }
}
