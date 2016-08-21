using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGenerator
{
    public class PersonData
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<string> bookList { get; set; }
    }
}
