using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LibraryGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonData> personDataList = new List<PersonData>();

            //---------------------------------------------------------------------------------------
            //Library XML generation part

            //List<string> generalBookList = BookListGenerator.GeneralBookListGenerator();
            //for (int i = 0; i < 10000; i++)
            //{
            //    PersonData personData = new PersonData();
            //    personData.name = WordGenerator.WordGeneratorMethod(8);
            //    Thread.Sleep(50);
            //    personData.surname = WordGenerator.WordGeneratorMethod(10);
            //    Thread.Sleep(50);
            //    personData.gender = GenderGenerator.GenderGeneratorMethod();
            //    Thread.Sleep(50);
            //    personData.age = IntGenerator.IntGeneratorMethod(88);
            //    Thread.Sleep(50);
            //    personData.bookList = BookListGenerator.PersonalBookListGenerator(generalBookList);
            //    personDataList.Add(personData);
            //}
            //Serializer.Serialize(personDataList, @"D:\LibraryDatabase.xml");
            //---------------------------------------------------------------------------------------

            personDataList = Serializer.Deserialize(@"D:\LibraryDatabase.xml");

            if (personDataList != null && personDataList.Count() > 0)
            {
                List<PersonData> maleList = new List<PersonData>();
                List<PersonData> femaleList = new List<PersonData>();
                List<PersonData> ageRangeList = new List<PersonData>();

                maleList = Statistic.GetMalesList(personDataList);
                femaleList = Statistic.GetFemalesList(personDataList);
                ageRangeList = Statistic.GetAgeRangeList(maleList, 24, 51);

                Console.WriteLine("Average amount of books that males have: {0:n0}", Statistic.GetAverageAmountOfBooks(maleList));
                Console.WriteLine("Average amount of books that females have: {0:n0}", Statistic.GetAverageAmountOfBooks(femaleList));
                Console.WriteLine("Average amount of books that males in age range 25-50 have: {0:n0}", Statistic.GetAverageAmountOfBooks(ageRangeList));
                Console.WriteLine("Average max of books that males in age range 25-50 have: {0}", Statistic.GetMaxAmountOfBooks(ageRangeList));
                Console.WriteLine("Average min of books that males in age range 25-50 have: {0}", Statistic.GetMinAmountOfBooks(ageRangeList));
                Console.WriteLine("The most popular book: {0}", Statistic.GetMostPopularBook(personDataList));
                Console.WriteLine("The least popular book: {0}", Statistic.GetLeastPopularBook(personDataList));
            }
            Console.ReadKey();
        }
    }
}
