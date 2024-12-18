namespace Enumerable.Except
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] id1 = { 44, 26, 92, 30, 71, 38 };
            int[] id2 = { 39, 59, 83, 47, 26, 4, 30 };
            
            var id1Except = id1.Except(id2);
            foreach (int id in id1Except)
                Console.WriteLine(id);
        }
    }
}
