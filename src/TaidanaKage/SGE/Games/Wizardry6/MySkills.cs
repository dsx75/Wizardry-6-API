using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MySkills : ISkills
    {

        internal MySkills(byte[] binData)
        {
            BinData = binData;
        }

        public byte[] BinData { get; }

    }
}
