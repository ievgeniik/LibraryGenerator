using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace LibraryGenerator
{
    public class Serializer
    {
        public static void Serialize(List<PersonData> personDataList, string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<PersonData>));
            using(TextWriter writer = new StreamWriter(file))
            {
                serializer.Serialize(writer, personDataList);
            }
        }
        public static List<PersonData> Deserialize(string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<PersonData>));
            List<PersonData> personDataList = new List<PersonData>();
            try
            {
                using (TextReader reader = new StreamReader(file))
                {
                    personDataList = (List<PersonData>)serializer.Deserialize(reader);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File '{0}' was not found", file);
            }
            return personDataList;
        }
    }
}
