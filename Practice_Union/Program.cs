namespace Practice_Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numb1 = new(){ "1","2","3" };
            List<string> numb2 = new(){ "3", "4", "5" };
            var unionNumb = numb1.Union(numb2);
            foreach (string str in unionNumb) 
            {
                Console.WriteLine(str);
            }
        }
    }
}





