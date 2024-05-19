namespace Practice_15._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department[] departments = CorporateData.Departments;
            Employee[] employees = CorporateData.Employees;
            IEnumerable<(long Id, string Name, IEnumerable<Employee> Employees)> items 
                = departments.GroupJoin
                (
                    employees, 
                    department => department.Id,
                    employee => employee.DepartmentId,
                    (department, departmentEmployees) => (department.Id, department.Name, departmentEmployees)
                );
            foreach (var item in items)
            { 
                Console.WriteLine(item.Name);
                foreach ( Employee employee in item.Employees) 
                {
                    Console.WriteLine("\t"+employee);
                }
            }
        }
    }
}