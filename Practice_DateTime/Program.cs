using System;

namespace Practice_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime t1 = DateTime.Now;
            Thread.Sleep(2000);
            DateTime t2 = DateTime.Now;

            TimeSpan t3 = t2 - t1;

            Console.WriteLine(t3.ToString());
        }
    }
}