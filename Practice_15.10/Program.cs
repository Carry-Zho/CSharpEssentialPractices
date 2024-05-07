using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_15._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            patents = patents.Where(patent => patent.YearOfPublication.StartsWith("18"));
            Print(patents);
        }

        private static void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}