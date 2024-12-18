namespace Practice_Enumerable.Where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> authors = new() { "Agatha Christie", "Bronte Sisters", "Cervantes",
                "Daniel Defoe", "Dostoevsky", "Goethe", "Gustave Flaubert" };
            var authorsStartsWithG = authors.Where<string>((string au) => { return au.StartsWith("G"); }).ToList();

        }
    }
}