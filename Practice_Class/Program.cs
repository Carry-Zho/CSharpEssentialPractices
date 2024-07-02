namespace Practice_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine(count);
            PrintCount(count);
            Console.WriteLine(count);

            Demo test = new Demo(100);
            Console.WriteLine(test.OjbectCount);
            PrintObjectCount(test);
            Console.WriteLine(test.OjbectCount);
        }
        static void PrintObjectCount( Demo dm)
        { 
            dm.OjbectCount = dm.OjbectCount + 1;
            dm = new Demo(10000);
            Console.WriteLine(dm.OjbectCount);
        }
        static void PrintCount(int value)
        { 
            value = value + 1;
            Console.WriteLine(value);
        }
    }
}
