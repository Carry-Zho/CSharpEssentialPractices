using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_15._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Patent> patents = (IEnumerable<Patent>)PatentData.Patents;
            Console.WriteLine($"Patent count: {patents.Count()}");
            Console.WriteLine($@"Patent count in 1800s: {patents.Count( item => item.YearOfPublication.StartsWith("18"))}");
        }
    }
}