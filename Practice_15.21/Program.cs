using System.Linq;
namespace Practice_15._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = CorporateData.Employees;
            IEnumerable<IGrouping<int, Employee>> groupedEmployees = employees.GroupBy(
                                                                                        employee => employee.DepartmentId
                                                                                       );
            foreach (IGrouping<int, Employee> employeeGroup in groupedEmployees)
            {
                Console.WriteLine();
                foreach(Employee employee in employeeGroup) 
                {
                    Console.WriteLine("\t"+employee);
                }
                Console.WriteLine("\tCount"+employeeGroup.Count());
            }
        }
    }
}