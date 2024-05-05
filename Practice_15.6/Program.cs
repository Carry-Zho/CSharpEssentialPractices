namespace Practice_15._6
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
            //foreach语法糖
            foreach(var item in dic) 
            {
                Console.WriteLine(item.Key+":"+item.Value);
            }
            //编译器实现的集合foreach操作，等价while循环--第二步
            Dictionary<string, string>.Enumerator enumerator;
            enumerator= dic.GetEnumerator();
            IDisposable disposable;
            try
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current.Key + ":" + enumerator.Current.Value);
                }
            }
            finally
            {
                //Explicit cast used for IEnumerator<T>
                disposable = (IDisposable)enumerator;
                disposable.Dispose();

                //IEnumerator will use the as operator unless IDisposable support is known at compile time
                //disposable = (enumerator as IDisposable);
                //if( disposable != null )
                //{
                //  disposable.Dispose();
                //}
            }

            //使用using的错误处理和资源清理
            using (enumerator = dic.GetEnumerator()) 
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current.Key+":"+enumerator.Current.Value);
                }
            }
        }
    }
}