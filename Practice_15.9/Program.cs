using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_15._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            Print(patents);

            Console.WriteLine("");

            IEnumerable<Inventor> inventors = PatentData.Inventors;
            Print(inventors);
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