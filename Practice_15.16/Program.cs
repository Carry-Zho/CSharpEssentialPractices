namespace Practice_15._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            bool result;
            patents = patents.Where(patent => 
            {
                if (result = patent.YearOfPublication.StartsWith("18"))
                {
                    //Side effects like this in a predicate
                    //are used here to demonstrate a principle
                    //and should generally be avoided
                    Console.WriteLine("\t" + patent);
                }
                return true;
            });
            Console.WriteLine("1. First patents prior to the 1900s:");
            foreach (Patent patent in patents)
            { 
            }
            Console.WriteLine($@"There are {patents.Count()} patents prior to 1900.");

            Console.WriteLine();
            Console.WriteLine("2. A second listing of patents prior to the 1900s:");
            Console.WriteLine($@"There are {patents.Count()} patents prior to 1900.");

            Console.WriteLine();
            Console.WriteLine("3. A third listing of patents prior to the 1900s:");
            patents = patents.ToArray();
            Console.Write("  There are ");
            Console.WriteLine($"{patents.Count()} patents prior to 1900.");
        }
    }
}