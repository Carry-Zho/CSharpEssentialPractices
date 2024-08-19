namespace Practice_BuildMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo dm = new Demo();
            Console.WriteLine(dm.Age);
        }
    }
    internal class Demo
    {
        public Demo() 
        {
            Console.WriteLine(Name);
        }
        static Demo() 
        {
            Console.WriteLine("初始值设定项实际上对应于构造函数头部自动生成的赋值语句。");
        }
        private static string Name = "Hi";
        public string Age = "21";
    }
}



