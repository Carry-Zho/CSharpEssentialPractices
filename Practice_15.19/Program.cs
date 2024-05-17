using System.Linq;

namespace Practice_15._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department[] departments = CorporateData.Departments;
            Employee[] employees = CorporateData.Employees;
            IEnumerable<(int Id, string Name, string Title, Department Department)> items = 
                employees.Join(departments,employee => employee.DepartmentId, department => department.Id, (employee, department) => (employee.Id, employee.Name, employee.Title, department));

            foreach(var item in items) 
            {
                Console.WriteLine($"{item.Name} ({item.Title})");
                Console.WriteLine("\t" + item.Department);
            }
        }
    }
}