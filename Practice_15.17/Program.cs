using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_15._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Patent> items;
            Patent[] patents = PatentData.Patents;
            items = patents.OrderBy(patent => patent.YearOfPublication).ThenBy(patent => patent.Title);
            Print(items);
            Console.WriteLine();
            items = patents.OrderBy(patent => patent.YearOfPublication).ThenByDescending(patent => patent.Title);
            Print(items);
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