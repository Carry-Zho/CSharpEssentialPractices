namespace Practice_Enumerable.Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { Name = "John", Age = 30 },
                new Customer { Name = "Jane", Age = 25 }
            };
            var customerInfo = customers.Select(c => new
            {
                c.Name,
                c.Age
            });

        }
    }
    internal class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}