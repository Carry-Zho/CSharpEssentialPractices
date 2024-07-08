namespace Practice_RefParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "张三";
            Console.WriteLine(person.Name);
            Print(in person);
            Console.WriteLine(person.Name);
        }
                                                            static void Print(in Person para1)
        {
            Console.WriteLine(para1.Name);
            para1.Name = "里斯";
            para1 = new Person();
        }
    }
}