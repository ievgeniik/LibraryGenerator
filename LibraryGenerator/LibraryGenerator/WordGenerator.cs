using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGenerator
{
    public class WordGenerator
    {
        public static string WordGeneratorMethod(int wordMaxLength)
        {
            Random wordLengthRand = new Random();
            Random wordCharRand = new Random();
            char[] wordCharArray = new char[wordLengthRand.Next(1, wordMaxLength)];
            for (int i =0; i < wordCharArray.Length; i++)
            {
                wordCharArray[i] = (char)wordCharRand.Next(0x0061, 0x007A);
            }
            string name = new string(wordCharArray);
            return name;
        }
    }
}
