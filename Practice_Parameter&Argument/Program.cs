namespace Practice_Parameter_Argument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "长三";
            string address = "地球村";
            Print(address: address, name: name);
        }

        static void Print(string name, string address)
        {
            Console.WriteLine(name + ":" + address);
        }
    }
}


