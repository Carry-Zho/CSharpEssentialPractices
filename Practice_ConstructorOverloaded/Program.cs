namespace Practice_ConstructorOverloaded
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    internal class Demo
    {
        private string Name, Age;
        //constructors
        public Demo() 
        { }
        public Demo(string name):this(age) 
        {
            Name = name;
        }
        public Demo(string age) 
        {
            Age = age;
        }
    }
}





