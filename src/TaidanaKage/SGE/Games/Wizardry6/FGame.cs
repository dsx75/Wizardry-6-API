using System;
using System.Collections.Generic;
using System.IO;

namespace TaidanaKage.SGE.Games.Wizardry6
{
    /// <summary>
    /// Factory methods
    /// </summary>
    public static class FGame
    {

        /// <summary>
        /// Reads the specified save game file.
        /// </summary>
        /// <param name="file">File</param>
        /// <returns>Save game</returns>
        public static ISaveGame ReadSaveGame(string fileName)
        {
            int offsetChar1 = 49856; // C2C0
            int hexDataLenght = 432;

            List<ICharacter> characters = new List<ICharacter>();

            if (File.Exists(fileName))
            {
                Console.WriteLine("Parsing " + fileName);
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    int length = (int)reader.BaseStream.Length;
                    Console.WriteLine("Lenght: " + length);
                    // TODO add check for lenght

                    reader.BaseStream.Seek(offsetChar1, SeekOrigin.Begin);

                    for (int ch = 1; ch < 7; ch++)
                    {
                        byte[] hexData = reader.ReadBytes(hexDataLenght);
                        ICharacter character = new MyCharacter(hexData);
                        characters.Add(character);
                    }
                }
            }
            return new MySaveGame(characters);
        }

        public static void WriteSaveGame(string file, ISaveGame saveGame)
        {
            // TODO
        }

        public static ICharacter CreateNewCharacter(string name)
        {
            return new MyCharacter(name);
        }


        public static void Check(ISaveGame saveGame)
        {
            // Character names must be unique

        }

    }
}
