namespace Practice_StaticModifier
{
    internal class Program
    {
        string test = "Static modifier";
        static string Description { get; set; } = "Static modifier";

        static void Main(string[] args)
        {
            //Console.WriteLine(test);
            Console.WriteLine(Program.Description);  
            Demo demo = new Demo() { Name = "长三", Address = "" };
            Console.WriteLine(demo.Name);
        }
    }
    internal class Demo
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}