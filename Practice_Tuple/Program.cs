namespace Practice_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, int Age) currentPerson = ("长三", 21);
            Console.WriteLine(currentPerson.Name);
            currentPerson.Name = "李四";
            Console.WriteLine(currentPerson.Name);
        }
    }
}