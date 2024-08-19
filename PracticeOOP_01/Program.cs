namespace PracticeOOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperClass superClass = new SuperClass() { Name ="SuperClass" };
            Console.WriteLine(SuperClass.Count);
            Console.WriteLine(superClass.Name);

            BaseClass baseClass = new BaseClass();
            Console.WriteLine(BaseClass.Count);
            Console.WriteLine(baseClass.Name);
        }
    }
    internal class BaseClass
    {
        public static int Count = 0;
        private string _Name = "BaseClass";
        public string Name 
        {
            get =>_Name; 
            set  =>_Name = value;
        }
        public BaseClass() 
        {
            BaseClass.Count++;
        }
    }
    internal class SuperClass : BaseClass
    {
        new public static int Count = 0;
        public SuperClass() 
        {
            SuperClass.Count = 100;
        }
    }
}