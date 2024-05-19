using System.Linq;

namespace Practice_15._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department[] departments = CorporateData.Departments;
            Employee[] employees = CorporateData.Employees;
            IEnumerable<(long Id, string Name, Employee Employee)> items = departments.Join(employees,department => department.Id, employee => employee.DepartmentId,(department, employee)=>(department.Id, department.Name, employee));
            foreach (var item in items) 
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("\t" + item.Employee);
            }
        }
    }
}