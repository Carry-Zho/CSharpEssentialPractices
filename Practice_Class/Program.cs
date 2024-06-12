namespace Practice_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiReturnFieldMethod().SayHi);
            MultiReturnFieldMethod().dm.SaySomething();

        }
        public static (string SayHi, Demo dm) MultiReturnFieldMethod()
        {
            return ("Hi CSharp.", new Demo());
        }
    }
}
