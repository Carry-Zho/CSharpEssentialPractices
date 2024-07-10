namespace Practice_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "长三";
            string address = "地球村";
            Print(name:name, address:address);

        }
        static void Print(string name, string address)
        { 
            Console.WriteLine(name + ":" + address);
        }
    }
}

