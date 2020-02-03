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

    }
}
