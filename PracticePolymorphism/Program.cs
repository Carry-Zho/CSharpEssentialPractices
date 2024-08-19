namespace PracticePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            SuperClass sc = (SuperClass)bc;
        }
    }
    internal class BaseClass
    {
    }
    internal class SuperClass
    {
    }
}




