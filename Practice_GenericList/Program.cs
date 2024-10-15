namespace Practice_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "1","1","2","3","4","4"};
            foreach (string item in list) 
            {
                Console.WriteLine(item);
            }
            list = list.Distinct().ToList();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}


