﻿using System;
using System.Text;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyCharacter : ICharacter
    {
        private byte[] _binData;
        private string _name;
        private IAttributes _attributes;

        internal MyCharacter(byte[] binData)
        {
            // TODO check if size of the hex chunk is correct (432)
            _binData = binData;

            // Character name (7 letters)
            _name = "";
            for (int i = 0; i < 7; i++)
            {
                _name += Convert.ToChar(_binData[i]);
            }

            // Attributes
            byte[] binDataAttributes = new byte[8];
            Array.Copy(_binData, 300, binDataAttributes, 0, 8);
            _attributes = new MyAttributes(binDataAttributes);
        }

        public byte[] BinData
        {
            get
            {
                return _binData;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // TODO add check - only English alphabet letters are allowed
                // TODO check for min required lenght 1
                // TODO check for max allowed lenght 7

                // Convert to uppercase
                _name = value.ToUpper();

                // Fill with NUL (ASCII 0) if it's shorter than 7 letters
                char c = '\x0';
                _name = _name.PadRight(7, c);

                // Update binary data
                byte[] binNew = Encoding.ASCII.GetBytes(_name);
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

        public Race Race { get; set; }

        public Sex Sex { get; set; }

        public Profession Profession { get; set; }

        public IAttributes Attributes
        {
            get
            {
                return _attributes;
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

    }
}
