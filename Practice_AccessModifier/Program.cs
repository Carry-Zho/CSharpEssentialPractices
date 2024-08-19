namespace Practice_AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    internal class PdaItem
    {
        public string Name { get; set; }
        protected Guid Id { get; set; }
        private DateTime CreationDate;
    }
    internal class Contract : PdaItem
    {
        void Load(PdaItem pdaItem)  //派生类内包含基类的对象
        { 
            pdaItem.Name = "changsan"; //public关键词显式指明成员在类的内部、外部均可以访问。

            pdaItem.CreationDate = DateTime.Now;  //Error,CreationDate不可访问，因为它具有一定的保护级别（private）。

            pdaItem.Id = Guid.NewGuid();  //Error,无法通过"PdaItem"类型访问受保护的成员"Id";类型必须是"Contract"。
                                          //protected成员只能通过this在包容类及其派生类内访问，不能通过其他对象访问，也不能在除此之外的任何地方访问。


            Contract contract1 = pdaItem as Contract;   //向上转型；等价转型操作符
            Contract contract2 = (Contract)pdaItem;     //向上转型；等价as操作符

            if (contract1 != null) 
            {
                contract1.Id = Guid.NewGuid();
            }
            //等价
            if (pdaItem != null)
            {
                ((Contract)pdaItem).Id = Guid.NewGuid();
            }
        }
    }
}