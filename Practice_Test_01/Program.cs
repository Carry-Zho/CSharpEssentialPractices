using System.Collections;
namespace Practice_Test_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            IEnumerator enumerator = numbers.GetEnumerator();
            while (enumerator.MoveNext()) 
            {
                int current = (int)enumerator.Current;
                Console.WriteLine(current);
            }
        }
    }
}