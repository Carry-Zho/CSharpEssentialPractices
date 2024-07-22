namespace Practice_nameof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tagName1 = "SuccessFlag";
            Console.WriteLine(nameof(tagName));
        }
    }



    internal class Demo
    {
        private string _Name;
        public string Name 
        { 
            get { return _Name; } 
            set 
            {
                if (!value.Contains("长"))
                    throw new ArgumentException(nameof(value));
                else
                    _Name = value; 
            } 
        }
        public void NameChanged(string p) 
        {
            throw new ArgumentException(p);
        }
    }
}