namespace Practice_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    internal abstract class ABSClass
    { 
        public abstract string Name { get; set; }
    }
    internal class BaseClass : ABSClass
    {
        public override string Name { get; set; }
    }
    internal class SuperClass : BaseClass
    {
        public override string Name { get; set; }
    }
}