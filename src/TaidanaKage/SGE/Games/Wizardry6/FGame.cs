using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
            byte[] binData = null;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    int length = (int)reader.BaseStream.Length;
                    Console.WriteLine("Lenght: " + length);
                    // TODO add check for lenght

                    binData = reader.ReadBytes(length);
                }
            }
            else
            {
                // TODO throw an exception - the specified file does not exist
            }
            return new MySaveGame(binData);
        }

        public static void WriteSaveGame(string fileName, ISaveGame saveGame)
        {
            File.WriteAllBytes(fileName, saveGame.BinData);
        }

        public static void Check(ISaveGame saveGame)
        {
            // Character names must be unique

        }

    }
}
