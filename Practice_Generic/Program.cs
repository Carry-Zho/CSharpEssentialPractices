namespace Practice_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public interface IEnumerable<out T> : System.Collections.IEnumerable
            IEnumerable<Derived> derivedList = new Derived[] { new Derived(),new Derived()};
            IEnumerable<Base> baseList = derivedList;   //协变

            //public delegate void Action<in T>(T obj);
            Action<Base> baseAction = x => { };
            Action<Derived> derivedAction = baseAction;  //逆变
        }
    }
    internal class Base { }
    internal class Derived : Base { }
}

