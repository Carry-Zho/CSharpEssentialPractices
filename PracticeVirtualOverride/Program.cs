namespace PracticeVirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    internal class BaseClass
    {
        public virtual void PrintSomething()
        {
            Console.WriteLine("I'm base class.");
        }
    }
    internal class SuperClass : BaseClass
    {
        new public void PrintSomething()
        {
            Console.WriteLine("I'm super class.");
        }
    }
    internal class FinalClass : SuperClass
    {
        public override void PrintSomething()
        {
            Console.WriteLine("I'm final class.");
        }
    }
}








