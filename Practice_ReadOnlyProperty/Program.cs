namespace Practice_ReadOnlyProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo dm = new Demo(){ _ReadOnlyProperty = "Hello"}; //无法分配只读字段（除非在定义该字段类型的构造函数中，或init-only资源库中，或在变量的初始值设定项中）
            Console.WriteLine(dm.ReadOnlyProperty);
        }
    }
    internal class Demo
    {
        public Demo() { }
        public Demo(string propertyValue)
        {
            _ReadOnlyProperty = propertyValue; //在构造函数中设置只读支持字段的值
        }
        public readonly string _ReadOnlyProperty = "nice";  //直接设置只读支持字段的初始值（初始值设定项）
        public string ReadOnlyProperty { get => _ReadOnlyProperty; }
    }
}


