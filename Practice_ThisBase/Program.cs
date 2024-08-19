namespace Practice_ThisBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperClass sc = new SuperClass();
            Console.WriteLine(sc.Name);
        }
    }
    internal class BaseClass
    {
        public string Name { get; set; }
        public BaseClass()
        {
        }
        public BaseClass(string name)
        {
            Name = name;
        }
    }
    internal class SuperClass : BaseClass
    {
        public SuperClass(): this("Base class")
        {
            Console.WriteLine(Name);
            Name = "Something changed";
        }
        public SuperClass(string name)
        {
            Console.WriteLine(Name);
            Name = name;
        }
    }
}








