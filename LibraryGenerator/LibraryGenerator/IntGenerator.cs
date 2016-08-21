using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGenerator
{
    public class IntGenerator
    {
        public static int IntGeneratorMethod(int maxInt)
        {
            Random ageRand = new Random();
            int age = ageRand.Next(1, maxInt);
            return age;
        }
    }
}
