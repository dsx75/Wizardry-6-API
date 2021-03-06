﻿using System;
using System.Text;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyCharacter : ICharacter
    {
        /// <summary>
        /// Relative offset (in Character data) for the Spell Points section.
        /// </summary>
        private const int OffsetSpellPoints = 40;

        /// <summary>
        /// Length (in bytes) of the Spell Points section.
        /// </summary>
        private const int LengthSpellPoints = 24;

        /// <summary>
        /// Relative offset (in Character data) for the Resistances section.
        /// </summary>
        private const int OffsetResistances = 338;

        /// <summary>
        /// Length (in bytes) of the Resistances section.
        /// </summary>
        private const int LengthResistances = 14;

        private byte[] _binData;
        private ISpellPoints _spellPoints;
        private IAttributes _attributes;
        private ISkills _skills;
        private IResistances _resistances;

        internal MyCharacter(byte[] binData)
        {
            // TODO check if size of the hex chunk is correct (432)
            _binData = binData;

            // Spell Points
            byte[] binDataSP = new byte[LengthSpellPoints];
            Array.Copy(_binData, OffsetSpellPoints, binDataSP, 0, LengthSpellPoints);
            _spellPoints = new MySpellPoints(binDataSP);

            // Attributes
            byte[] binDataAttributes = new byte[Constants.LengthAttributes];
            Array.Copy(_binData, Constants.OffsetAttributes, binDataAttributes, 0, Constants.LengthAttributes);
            _attributes = new MyAttributes(binDataAttributes);

            // Skills
            byte[] binDataSkills = new byte[Constants.LengthSkills];
            Array.Copy(_binData, Constants.OffsetSkills, binDataSkills, 0, Constants.LengthSkills);
            _skills = new MySkills(binDataSkills);

            // Resistances
            byte[] binDataResistances = new byte[LengthResistances];
            Array.Copy(_binData, OffsetResistances, binDataResistances, 0, LengthResistances);
            _resistances = new MyResistances(binDataResistances);
        }

        public byte[] BinData
        {
            get
            {
                // Update each sub-section of bin data (in case they've been modified)

                // Spell Points
                Array.Copy(SpellPoints.BinData, 0, _binData, OffsetSpellPoints, LengthSpellPoints);

                // Attributes
                Array.Copy(Attributes.BinData, 0, _binData, Constants.OffsetAttributes, Constants.LengthAttributes);

                // Skills
                Array.Copy(Skills.BinData, 0, _binData, Constants.OffsetSkills, Constants.LengthSkills);

                // Resistances
                Array.Copy(Resistances.BinData, 0, _binData, OffsetResistances, LengthResistances);

                return _binData;
            }
        }

        public string Name
        {
            get
            {
                string name = "";
                for (int i = 0; i < 7; i++)
                {
                    name += Convert.ToChar(_binData[i]);
                }
                return name.Trim();
            }
            set
            {
                string name = value;
                if (name == null)
                {
                    throw new ArgumentNullException("name", "Character name can not be null.");
                }
                name = name.Trim();
                name = name.ToUpper();
                // TODO add check - only English alphabet letters are allowed
                if (name.Length < Constants.MinNameLength)
                {
                    throw new ArgumentOutOfRangeException("name", "Character name is too short.");
                }
                if (name.Length > Constants.MaxNameLength)
                {
                    name = name.Substring(0, Constants.MaxNameLength);
                }
                // Fill with NUL (ASCII 0) if it's shorter than 7 letters
                char c = '\x0';
                name = name.PadRight(7, c);
                // Update binary data
                byte[] binNew = Encoding.ASCII.GetBytes(name);
                Array.Copy(binNew, 0, _binData, 0, 7);
            }
        }

        public int Age
        {
            get
            {
                return (int)(_binData[8] + (Constants.Pow8 * _binData[9]) + (Constants.Pow16 * _binData[10]) + (Constants.Pow24 * _binData[11]));
            }
            set
            {
                int age = value;
                if (age < Constants.MinAge)
                {
                    age = Constants.MinAge;
                }
                if (age > Constants.MaxAge)
                {
                    age = Constants.MaxAge;
                }
                byte[] b = BitConverter.GetBytes(age);
                _binData[8] = b[0];
                _binData[9] = b[1];
                _binData[10] = b[2];
                _binData[11] = b[3];
            }
        }

        public int AgeInYears
        {
            get
            {
                return Age / Constants.DaysInYear;
            }
            set
            {
                int age = value * Constants.DaysInYear;
                Age = age;
            }
        }

        public int Experience
        {
            get
            {
                return (int)(_binData[12] + (Constants.Pow8 * _binData[13]) + (Constants.Pow16 * _binData[14]) + (Constants.Pow24 * _binData[15]));
            }
            set
            {
                int xp = value;
                if (xp < Constants.MinXp)
                {
                    xp = Constants.MinXp;
                }
                if (xp > Constants.MaxXp)
                {
                    xp = Constants.MaxXp;
                }
                byte[] b = BitConverter.GetBytes(xp);
                _binData[12] = b[0];
                _binData[13] = b[1];
                _binData[14] = b[2];
                _binData[15] = b[3];
            }
        }

        public int Kills
        {
            get
            {
                return (int)(_binData[16] + (Constants.Pow8 * _binData[17]) + (Constants.Pow16 * _binData[18]) + (Constants.Pow24 * _binData[19]));
            }
            set
            {
                int kills = value;
                if (kills < Constants.MinKills)
                {
                    kills = Constants.MinKills;
                }
                if (kills > Constants.MaxKills)
                {
                    kills = Constants.MaxKills;
                }
                byte[] b = BitConverter.GetBytes(kills);
                _binData[16] = b[0];
                _binData[17] = b[1];
                _binData[18] = b[2];
                _binData[19] = b[3];
            }
        }

        public int GoldPieces
        {
            get
            {
                return (int)(_binData[20] + (Constants.Pow8 * _binData[21]) + (Constants.Pow16 * _binData[22]) + (Constants.Pow24 * _binData[23]));
            }
            set
            {
                int gp = value;
                if (gp < Constants.MinGold)
                {
                    gp = Constants.MinGold;
                }
                if (gp > Constants.MaxGold)
                {
                    gp = Constants.MaxGold;
                }
                byte[] b = BitConverter.GetBytes(gp);
                _binData[20] = b[0];
                _binData[21] = b[1];
                _binData[22] = b[2];
                _binData[23] = b[3];
            }
        }

        public short CurrentHitPoints
        {
            get
            {
                return (short)(_binData[24] + (Constants.Pow8 * _binData[25]));
            }
            set
            {
                short hp = value;
                if (hp < Constants.MinHitPoints)
                {
                    hp = Constants.MinHitPoints;
                }
                if (hp > Constants.MaxHitPoints)
                {
                    hp = Constants.MaxHitPoints;
                }
                if (hp > TotalHitPoints)
                {
                    hp = TotalHitPoints;
                }
                byte[] b = BitConverter.GetBytes(hp);
                _binData[24] = b[0];
                _binData[25] = b[1];
            }
        }

        public short TotalHitPoints
        {
            get
            {
                return (short)(_binData[26] + (Constants.Pow8 * _binData[27]));

            }
            set
            {
                short hp = value;
                if (hp < Constants.MinHitPoints)
                {
                    hp = Constants.MinHitPoints;
                }
                if (hp > Constants.MaxHitPoints)
                {
                    hp = Constants.MaxHitPoints;
                }
                byte[] b = BitConverter.GetBytes(hp);
                _binData[26] = b[0];
                _binData[27] = b[1];
            }
        }

        public short CurrentStamina
        {
            get
            {
                return (short)(_binData[28] + (Constants.Pow8 * _binData[29]));
            }
            set
            {
                short stm = value;
                if (stm < Constants.MinStamina)
                {
                    stm = Constants.MinStamina;
                }
                if (stm > Constants.MaxStamina)
                {
                    stm = Constants.MaxStamina;
                }
                if (stm > TotalStamina)
                {
                    stm = TotalStamina;
                }
                byte[] b = BitConverter.GetBytes(stm);
                _binData[28] = b[0];
                _binData[29] = b[1];
            }
        }

        public short TotalStamina
        {
            get
            {
                return (short)(_binData[30] + (Constants.Pow8 * _binData[31]));
            }
            set
            {
                short stm = value;
                if (stm < Constants.MinStamina)
                {
                    stm = Constants.MinStamina;
                }
                if (stm > Constants.MaxStamina)
                {
                    stm = Constants.MaxStamina;
                }
                byte[] b = BitConverter.GetBytes(stm);
                _binData[30] = b[0];
                _binData[31] = b[1];
            }
        }

        public short CurrentCarryingCapacity
        {
            get
            {
                return (short)(_binData[32] + (Constants.Pow8 * _binData[33]));
            }
            set
            {
                short cc = value;
                if (cc < Constants.MinCarryingCapacity)
                {
                    cc = Constants.MinCarryingCapacity;
                }
                if (cc > Constants.MaxCarryingCapacity)
                {
                    cc = Constants.MaxCarryingCapacity;
                }
                if (cc > TotalCarryingCapacity)
                {
                    cc = TotalCarryingCapacity;
                }
                byte[] b = BitConverter.GetBytes(cc);
                _binData[32] = b[0];
                _binData[33] = b[1];
            }
        }

        public short TotalCarryingCapacity
        {
            get
            {
                return (short)(_binData[34] + (Constants.Pow8 * _binData[35]));
            }
            set
            {
                short cc = value;
                if (cc < Constants.MinCarryingCapacity)
                {
                    cc = Constants.MinCarryingCapacity;
                }
                if (cc > Constants.MaxCarryingCapacity)
                {
                    cc = Constants.MaxCarryingCapacity;
                }
                byte[] b = BitConverter.GetBytes(cc);
                _binData[34] = b[0];
                _binData[35] = b[1];
            }
        }

        public short Level
        {
            get
            {
                return (short)(_binData[36] + (Constants.Pow8 * _binData[37]));
            }
            set
            {
                short level = value;
                if (level < Constants.MinLevel)
                {
                    level = Constants.MinLevel;
                }
                if (level > Constants.MaxLevel)
                {
                    level = Constants.MaxLevel;
                }
                byte[] b = BitConverter.GetBytes(level);
                _binData[36] = b[0];
                _binData[37] = b[1];
            }
        }

        public short Rebirths
        {
            get
            {
                return (short)(_binData[38] + (Constants.Pow8 * _binData[39]));
            }
            set
            {
                short rebirths = value;
                if (rebirths < Constants.MinRebirths)
                {
                    rebirths = Constants.MinRebirths;
                }
                if (rebirths > Constants.MaxRebirths)
                {
                    rebirths = Constants.MaxRebirths;
                }
                byte[] b = BitConverter.GetBytes(rebirths);
                _binData[38] = b[0];
                _binData[39] = b[1];
            }
        }

        public ISpellPoints SpellPoints
        {
            get
            {
                return _spellPoints;
            }
        }

        public IAttributes Attributes
        {
            get
            {
                return _attributes;
            }
        }

        public ISkills Skills
        {
            get
            {
                return _skills;
            }
        }

        public IResistances Resistances
        {
            get
            {
                return _resistances;
            }
        }

        public Race Race { get; set; }

        public Sex Sex { get; set; }

        public Profession Profession { get; set; }

    }
}
