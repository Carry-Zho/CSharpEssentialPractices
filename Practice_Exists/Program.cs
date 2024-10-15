namespace Practice_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"ChangSan","MeiSi","Others" };
            Console.WriteLine(Array.Find(names, name => name.Equals("ChangSan")));
            Console.WriteLine(default(string) == Array.Find(names, name => name.Equals("Ok")));
            Console.WriteLine(Array.Find(names, name => name.Equals("MeiSi")));
        }
    }
}