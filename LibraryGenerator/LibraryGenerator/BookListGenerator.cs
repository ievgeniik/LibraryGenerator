using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LibraryGenerator
{
    class BookListGenerator
    {
        public static List<string> GeneralBookListGenerator()
        {
            List<string> generalBookList = new List<string>();
            for (int i = 0; i < 50; i++)
            {
                generalBookList.Add(WordGenerator.WordGeneratorMethod(12));
                Thread.Sleep(50);
            }
            return generalBookList;
        }
        public static List<string> PersonalBookListGenerator(List<string> generalBookList)
        {
            List<string> personalBookList = new List<string>();
            Random personalBookListRand = new Random();
            int bookCount = IntGenerator.IntGeneratorMethod(50);
            Thread.Sleep(50);
            string firstGeneralBook = generalBookList[personalBookListRand.Next(generalBookList.Count)];
            Thread.Sleep(50);
            personalBookList.Add(firstGeneralBook);
            for (int ii = 0; ii < bookCount; ii++)
            {
                string generalBook = generalBookList[personalBookListRand.Next(generalBookList.Count)];
                Thread.Sleep(50);
                bool containsBook = personalBookList.Contains(generalBook);
                if (containsBook == false)
                {
                    personalBookList.Add(generalBook);
                }
            }
            return personalBookList;
        }
    }
}
