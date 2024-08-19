namespace Practice_Multi_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperClass superInstance = new SuperClass(new BaseClass1(),new BaseClass2(), "Moon Village");
            Console.WriteLine("Name:{0}" + Environment.NewLine+"Age:{1}" + Environment.NewLine+"Address:{2}",
                superInstance.baseInstance1.Name,
                superInstance.baseInstance2.Age,
                superInstance.Address);
        }
    }
    internal class BaseClass1
    {
        public string Name { get; set; } = "ChangSan";
    }
    internal class BaseClass2
    {
        public int Age { get; set; } = 10000;
    }
    internal class SuperClass
    {
        public BaseClass1 baseInstance1 { get; set; }
        public BaseClass2 baseInstance2 { get; set;}
        public string Address { get; set; }
        public SuperClass(BaseClass1 b1, BaseClass2 b2, string address)
        { 
            this.baseInstance1 = b1;
            this.baseInstance2 = b2;
            this.Address = address;
        }
    }
}