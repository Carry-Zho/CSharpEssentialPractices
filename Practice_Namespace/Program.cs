using newTimer = System.Timers.Timer;
using dtSpace = System.Data.Common;

namespace Practice_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            newTimer timer =  new newTimer();
            timer.Start();
        }
    }
}
