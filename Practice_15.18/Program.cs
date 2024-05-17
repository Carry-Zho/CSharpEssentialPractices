namespace Practice_15._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Department> departments = CorporateData.Departments;
            Print(departments);
            Console.WriteLine();
            IEnumerable<Employee> employees = CorporateData.Employees;
            Print(employees);
        }
        private static void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}