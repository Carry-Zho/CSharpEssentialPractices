using System.Diagnostics;

namespace Practice_Finalize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleClass ex = new ExampleClass();
            ex.ShowDuration();
        }
    }
    public class ExampleClass
    {
        Stopwatch sw;

        public ExampleClass()
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Instantiated object");
        }

        public void ShowDuration()
        {
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }

        ~ExampleClass()
        {
            Console.WriteLine("Finalizing object");
            sw.Stop();
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }
    }
}