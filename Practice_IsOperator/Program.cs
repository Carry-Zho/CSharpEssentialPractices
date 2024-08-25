namespace Practice_IsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object obj1 = new SuperClass() { Word = "SuperClass" };
            Object obj2 = new BaseClass() { Word = "BaseClass" };
            Object obj3 = new RootBaseClass() { Word = "A" };
            Object obj4 = new RootBaseClass() { Word = "B" };
            Object obj5 = new RootBaseClass() { Word = "C" };
            Object obj6 = new RootBaseClass() { Word = "D" };
            Object obj7 = new object();
            Object obj8 = null;
            PrintType(obj1);
            PrintType(obj2);
            PrintType(obj3);
            PrintType(obj4);
            PrintType(obj5);
            PrintType(obj6);    //命中类RootBaseClass，未命中口令:A、B、C
            PrintType(obj7);    //未命中任何指定类型
            PrintType(obj8);
        }
        static void PrintType(Object obj)
        {
            switch (obj) 
            {
                case null:   //case null可以放置在任何位置
                    {
                        Console.WriteLine(nameof(obj) + " is null"); 
                        //throw new ArgumentNullException(nameof(obj)); 若使用抛出异常语句，throw后可不写break，因为break不可到达。
                        break;
                    }
                default:    //default子句可放置在任何位置
                    {
                        Console.WriteLine(nameof(obj) + " is not in scope.");
                        break;
                    }
                //同一条继承链上的类型在模式匹配switch中必需派生类在前，基类在后，因为所有派生类的实例都是基类型的实例，
                //位置错误可造成派生类case永远得不到执行
                case SuperClass superClass:
                    {
                        Console.WriteLine(nameof(obj)+" is SuperClass");
                        break;
                    }
                case BaseClass:
                    {
                        Console.WriteLine(nameof(obj) + " is BaseClass");
                        break;
                    }
                case RootBaseClass rootBaseClass when rootBaseClass.Word == "A":
                    {
                        Console.WriteLine(nameof(obj) + " is RootBaseClass Type and "+nameof(obj) + " Word is A");
                        break;
                    }
                case RootBaseClass rootBaseClass when rootBaseClass.Word == "B":
                    {
                        Console.WriteLine(nameof(obj) + " is RootBaseClass Type and " + nameof(obj) + " Word is B");
                        break;
                    }
                case RootBaseClass rootBaseClass when rootBaseClass.Word == "C":
                    {
                        Console.WriteLine(nameof(obj) + " is RootBaseClass Type and " + nameof(obj) + " Word is C");
                        break;
                    }
            }
        }
    }
    internal class RootBaseClass 
    {
        public string Word { get; set; }
    }
    internal class BaseClass : RootBaseClass { }
    internal class SuperClass : BaseClass { }
}
