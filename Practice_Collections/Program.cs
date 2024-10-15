using System.Collections;

namespace Practice_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary persons = new Hashtable();
            persons.Add(110, 119);
            persons.Add("Changsan", "WangBaduan");
            Console.WriteLine(persons.Contains(110));
            Console.WriteLine(persons.Contains("Lisi"));
        }
    }
}