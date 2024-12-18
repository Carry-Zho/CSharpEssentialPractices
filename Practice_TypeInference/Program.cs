namespace Practice_TypeInference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void PrintType<T1, T2>(T1 param1, T2 param2,Func<T1,T2> func)
        {

        }
        static void Exchange<T1,T2>(T1 param1, T2 param2)
        { 

        }
    }
}