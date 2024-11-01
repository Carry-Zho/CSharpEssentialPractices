namespace Practice_Enumerator
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
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            ////编译器实现的集合foreach操作，等价while循环（一阶段），未做异常处理和资源清理
            KeyValuePair<string, string> pair;
            var enumerator = dic.GetEnumerator();
        }
    }
}
