using System;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    internal class MyCharacter : ICharacter
    {

        internal MyCharacter(string name)
        {
            Name = name;
        }

        internal MyCharacter(byte[] hexData)
        {
            // TODO check if size of the hex chunk is correct (432)

            string name = "";
            for (int i = 0; i < 7; i++)
            {
                name += Convert.ToChar(hexData[i]);
            }
            Name = name;
        }

        public string Name { get; set; }

        public Race Race { get; set; }

        public Sex Sex { get; set; }

        public Profession Profession { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Piety { get; set; }

        public int Vitality { get; set; }

        public int Dexterity { get; set; }

        public int Speed { get; set; }

        public int Personality { get; set; }

        public int Karma { get; set; }

    }
}
