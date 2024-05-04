using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Practice_15._2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ConsoleColor> colorMap = new Dictionary<string, ConsoleColor>
            {
                ["Error"] = ConsoleColor.Red,
                ["Warning"] = ConsoleColor.Yellow,
                ["Information"] = ConsoleColor.Green,
                ["Verbose"] = ConsoleColor.White
            };
            foreach(KeyValuePair<string, ConsoleColor> color in colorMap)
            {
                Console.WriteLine(color.Key + ":"+ color.Value);
            }
            Console.ReadLine();
        }
    }
}