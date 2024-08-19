using static Practice_DemoNamespace.ExtendClass;  //导入定义扩展方法的静态类
using Practice_DemoNamespace;  //或者导入定义扩展方法的静态类的命名空间

namespace Practice_StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee emp = new Employee();
            emp.Age();
        }
    }
    internal class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}