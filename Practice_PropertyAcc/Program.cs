namespace Practice_PropertyAcc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo dm = new Demo() { };
            Console.WriteLine(dm.Test);
        }
    }
}
internal class Demo
{
    public string Test { get; protected set; } = "nice";
}
