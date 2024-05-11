namespace Practice_15._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            bool result;
            Array array;
            array = patents.Where(patent => 
            {
                if (result = patent.YearOfPublication.StartsWith("18"))
                {
                    //Side effects like this in a predicate
                    //are used here to demonstrate a principle
                    //and should generally be avoided
                    Console.WriteLine("\t" + patent);
                }
                return true;
            }).ToArray();
            
            Console.WriteLine(array.Length);
        }
    }
}