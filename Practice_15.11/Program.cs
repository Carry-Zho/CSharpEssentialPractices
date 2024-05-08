using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_15._11
{
    internal class Program
    {
        private static void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            IEnumerable<Patent> patentsOf1800 = patents.Where(patent => patent.YearOfPublication.StartsWith("18"));
            Print(patentsOf1800);
            Console.WriteLine("*************************************************************");
            IEnumerable<string> items = patentsOf1800.Select(patent => patent.Title + ":" +patent.YearOfPublication);
            Print(items); 
        }
    }
}