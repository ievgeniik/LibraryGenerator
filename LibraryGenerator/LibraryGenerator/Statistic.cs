using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGenerator
{
    public static class Statistic
    {
        public static List<PersonData> GetMalesList(List<PersonData> personDataList)
        {
            var male = from personData in personDataList where personData.gender == "male" select personData;
            return male.ToList<PersonData>();
        }
        public static List<PersonData> GetFemalesList(List<PersonData> personDataList)
        {
            var female = from personData in personDataList where personData.gender == "female" select personData;
            return female.ToList<PersonData>();
        }
        public static List<PersonData> GetAgeRangeList(List<PersonData> personDataList, int minAge, int maxAge)
        {
            var ageRange = from personData in personDataList where personData.age > minAge && personData.age < maxAge select personData;
            return ageRange.ToList<PersonData>();
        }
        public static Dictionary<string, int> GetBookDictionary(List<PersonData> personDataList)
        {
            Dictionary<string, int> bookDictionary = new Dictionary<string, int>();
            foreach (var personData in personDataList)
            {
                foreach (var book in personData.bookList)
                {
                    if (bookDictionary.ContainsKey(book))
                    {
                        bookDictionary[book]++;
                    }
                    else
                    {
                        bookDictionary.Add(book, 1);
                    }
                }
            }
            return bookDictionary;
        }
        public static string GetMostPopularBook(List<PersonData> personDataList)
        {
            string mostPopularBook = null;
            Dictionary<string, int> bookDictionary = Statistic.GetBookDictionary(personDataList);
            int max = 0;
            foreach (KeyValuePair<string, int> book in bookDictionary)
            {
                if (book.Value > max)
                {
                    mostPopularBook = book.Key;
                    max = book.Value;
                }
            }
            return mostPopularBook;
        }
        public static string GetLeastPopularBook(List<PersonData> personDataList)
        {
            string leastPopularBook = null;
            Dictionary<string, int> bookDictionary = Statistic.GetBookDictionary(personDataList);
            int min = 10001;
            foreach (KeyValuePair<string, int> book in bookDictionary)
            {
                if (book.Value < min)
                {
                    leastPopularBook = book.Key;
                    min = book.Value;
                }
            }
            return leastPopularBook;
        }
        public static double GetAverageAmountOfBooks(this List<PersonData> personDataList)
        {
            return personDataList.Average(personData => personData.bookList.Count);
        }
        public static int GetMaxAmountOfBooks(this List<PersonData> personDataList)
        {
            return personDataList.Max(personData => personData.bookList.Count);
        }
        public static int GetMinAmountOfBooks(this List<PersonData> personDataList)
        {
            return personDataList.Min(personData => personData.bookList.Count);
        }
    }
}
