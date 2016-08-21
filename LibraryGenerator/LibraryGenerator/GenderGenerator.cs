using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGenerator
{
    public class GenderGenerator
    {
        public static string GenderGeneratorMethod()
        {
            string gender;
            Random genderRand = new Random();
            int genderInt = genderRand.Next(0, 9);
            if (genderInt < 5)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            return gender;
        }
    }
}
