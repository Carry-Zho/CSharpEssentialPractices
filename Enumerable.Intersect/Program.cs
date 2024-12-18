﻿namespace Enumerable.Intersect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] id1 = { 44, 26, 92, 30, 71, 38 };
            int[] id2 = { 39, 59, 83, 47, 26, 4, 30 };

            IEnumerable<int> both = id1.Intersect(id2);

            foreach (int id in both)
                Console.WriteLine(id);
        }
    }
}
