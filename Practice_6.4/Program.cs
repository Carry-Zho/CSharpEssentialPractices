namespace Practice_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee treeSang = new Employee() { FirstName = "三", LastName = "张", Age = 21 };
            Console.WriteLine(treeSang.FirstName+" "+treeSang.LastName+ " "+ treeSang.Age);
        }
    }
}