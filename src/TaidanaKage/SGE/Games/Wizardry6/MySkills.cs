using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MySkills : ISkills
    {
        private const int offsetWeaponry = 0;
        private const int lenghtWeaponry = 10;

        private const int offsetPhysical = 10;
        private const int lenghtPhysical = 7;

        private const int offsetPersonal = 17;
        private const int lenghtPersonal = 5;

        private const int offsetAcademia = 22;
        private const int lenghtAcademia = 8;

        private byte[] _binData;
        private IWeaponrySkills _weaponry;
        private IPhysicalSkills _physical;
        private IPersonalSkills _personal;
        private IAcademiaSkills _academia;

        internal MySkills(byte[] binData)
        {
            _binData = binData;

            // Weaponry skills
            byte[] binDataWeaponry = new byte[lenghtWeaponry];
            Array.Copy(_binData, offsetWeaponry, binDataWeaponry, 0, lenghtWeaponry);
            _weaponry = new MyWeaponrySkills(binDataWeaponry);

            // Physical skills
            byte[] binDataPhysical = new byte[lenghtPhysical];
            Array.Copy(_binData, offsetPhysical, binDataPhysical, 0, lenghtPhysical);
            _physical = new MyPhysicalSkills(binDataPhysical);

            // Personal skills
            byte[] binDataPersonal = new byte[lenghtPersonal];
            Array.Copy(_binData, offsetPersonal, binDataPersonal, 0, lenghtPersonal);
            _personal = new MyPersonalSkills(binDataPersonal);

            // Academia skills
            byte[] binDataAcademia = new byte[lenghtAcademia];
            Array.Copy(_binData, offsetAcademia, binDataAcademia, 0, lenghtAcademia);
            _academia = new MyAcademiaSkills(binDataAcademia);
        }

        public byte[] BinData
        {
            get
            {
                // Update bin data with Weaponry Skills (in case they've been modified)
                Array.Copy(Weaponry.BinData, 0, _binData, offsetWeaponry, lenghtWeaponry);

                // Update bin data with Physical Skills (in case they've been modified)
                Array.Copy(Physical.BinData, 0, _binData, offsetPhysical, lenghtPhysical);

                // Update bin data with Personal Skills (in case they've been modified)
                Array.Copy(Personal.BinData, 0, _binData, offsetPersonal, lenghtPersonal);

                // Update bin data with Academia Skills (in case they've been modified)
                Array.Copy(Academia.BinData, 0, _binData, offsetAcademia, lenghtAcademia);

                return _binData;
            }
        }

        public IWeaponrySkills Weaponry
        {
            get
            {
                return _weaponry;
            }
        }

        public IPhysicalSkills Physical
        {
            get
            {
                return _physical;
            }
        }

        public IPersonalSkills Personal
        {
            get
            {
                return _personal;
            }
        }

        public IAcademiaSkills Academia
        {
            get
            {
                return _academia;
            }
        }

    }
}
