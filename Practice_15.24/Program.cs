namespace Practice_15._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Team, string[] Players)[] worldCup2006Finalists = new[] 
            { 
                (Team:"France", Players: new string[]{ "Fabien Barthez", "Gregory Coupet"}),
                (Team:"Italy", Players: new string[]{ "Gianluigi Buffon", "Angelo Peruzzi"})
            };
            IEnumerable<string> players = worldCup2006Finalists.SelectMany(team => team.Players);
            Print(players);
        }
        private static void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}