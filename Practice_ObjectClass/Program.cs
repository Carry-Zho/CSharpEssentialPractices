namespace Practice_ObjectClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String suffix = "Suffix";  //编译器自动将字符串字面值"Suffix"添加至内部化池
            String s1 = "StringSuffix";  //编译器自动将字符串字面值"StringSuffix"添加至内部化池
            String s2 = "String" + suffix;  //运行时创建string实例，未调用String.Intern，不会被添加或引用至内部化池
                                            //此时，内部化池中有一份"StringSuffix",内部化池外有一份"StringSuffix"

            Console.WriteLine("{0} isInterned: {1}", s2, String.IsNullOrEmpty(String.IsInterned(s2)) ? "No" : "Yes");
            Console.WriteLine("s1 = s2: {0}", Object.ReferenceEquals(s1, s2));
        }
    }
}
