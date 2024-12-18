namespace Practice_Enumerable.SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Team, string No,string[] Players)[] worldCup2006Finalists = new[]
            {
                ("France", "1",new string[]{ "Fabien Barthez", "Gregory Coupet"}),
                ("Italy", "2", new string[]{ "Gianluigi Buffon", "Angelo Peruzzi"})
            };
            var teamAndplayers = worldCup2006Finalists.SelectMany(ele => ele.Players,(ele,mid) => new{ ele,mid });
            foreach(var player in teamAndplayers) 
            {
                Console.WriteLine(player.ele.Players);
                Console.WriteLine(player.ele.Team + " " +player.ele.No + " " + player.mid);
            }
        }
    }
}