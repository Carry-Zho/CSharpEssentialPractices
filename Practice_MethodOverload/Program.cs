namespace Practice_MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Hi C#",2);
        }
        public static void SayHi(string something) { Console.WriteLine(something); }
        public static void SayHi(string something, int times)
        {
            while (times > 0 ) 
            {
                SayHi(something);
                times--;
            }
        }
    }
}
