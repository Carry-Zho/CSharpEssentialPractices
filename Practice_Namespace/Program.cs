namespace Practice_Namespace
{
    namespace Practice_Inner
    { 
        //命名空间内嵌命名空间
    }
    internal class Program
    {
        int dummyNumber;
        class DummyTemplate { int number; } //类内内嵌的类
        static void Main(string[] args)
        {
            Console.WriteLine(dummyNumber); //Error:局部变量“dummyNumber”在声明之前无法使用。
                                            //声明该局部变量将隐藏字段“Program.dummyNumber”
            var dummyNumber = 1; //方法作用域内可重复声明外层作用域声明的标识符。
            if(true) 
            {
                var dummyNumber = 2; //Error:无法在此范围中声明名为“dummyNumber”的局部变量，
                                     //因为该名称已在封闭局部范围中用于定义局部变量或参数。
            }            
        }        
    }
}