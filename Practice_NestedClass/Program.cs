namespace Practice_NestedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        private string Age_Container = "18";

        private class NestedClass
        {
            public string Name { get; set; }
            private string Age { get; set; } = Age_Container;
        }
    }
}