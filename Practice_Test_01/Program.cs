namespace Practice_Test_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                ["Name"] = "CSharp",
                ["Version"] = "1.0",
                ["Author"] = "Author"
            };

            Dictionary<string, string>.Enumerator enumerator = dic.GetEnumerator();
            Console.WriteLine(enumerator.Current.Value == null);  //true
            Console.WriteLine(enumerator.Current.Value == null);  //true
        }
    }
}