using System.Collections;

namespace Practice_Test_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>
            {
                new Person { ID = "001", Name = "Alice", Address = "US" },
                new Person { ID = "002", Name = "Msk", Address = "UK" },
                new Person { ID = "003", Name = "Tku", Address = "JP" }
            };

            Dictionary<string, string> peoDic = peopleList
                .ToDictionary(item => item.ID, item => item.Name);

            foreach(var item in peoDic)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

        }
    }
}