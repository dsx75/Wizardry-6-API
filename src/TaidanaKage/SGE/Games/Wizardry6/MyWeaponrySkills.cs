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

    }
}
