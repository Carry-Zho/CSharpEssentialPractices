namespace Practice_ObjectRelationship
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    internal class Helper
    {
        public void Help()
        {
            Console.WriteLine("...");
        }
    }
    internal class Service
    {
        public void PerformService(Helper helper)  //Service类依赖Helper
        {
            helper.Help();
        }
    }

}