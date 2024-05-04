using System;
using System.Collections.Generic;

namespace Practice_15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> saySomething = new List<string>
            {
                "Hi",
                "CSharp",
                "the best programing language"
            };

            Print(saySomething);
            Console.ReadKey();
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