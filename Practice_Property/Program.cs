namespace Practice_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee epl = new Employee();
            epl.FirstName = "长三";
            Console.WriteLine(epl.FirstName);
        }
    }
    internal class Employee
    {
        private bool _IsTheMan;
        public bool GetIsTheMan => _IsTheMan;
        private string _FirstName;
        public string FirstName
        {
            get => _FirstName;
            set 
            {
                if (value == "三长")
                {
                    _IsTheMan = true;
                    _FirstName = value;
                }
                else 
                {
                    _IsTheMan = false;
                    _FirstName = "No body";
                }                   
            }
        }
    }
}