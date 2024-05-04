using System;
using System.Collections.Generic;
using System.Net.Cache;

namespace Practice_15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> saySomething;
            saySomething= new List<string>
            {
                "Hi",
                "CSharp",
                "the best programing language"
            };
            Print(saySomething);
            Demo demoObject;
            demoObject = new Demo { Name = "CSharp", Age = 21 };
            Console.WriteLine(demoObject.Name);
            Console.WriteLine(demoObject.Age);
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