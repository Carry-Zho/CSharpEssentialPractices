using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_15._20
{
    public static class CorporateData
    {
        public static readonly Department[] Departments = new Department[]
        {
            new Department(){ Id = 0, Name = "Corporate"},
            new Department(){ Id = 1, Name = "Human Resources"},
            new Department(){ Id = 2, Name = "Engineering"},
            new Department(){ Id = 3, Name = "Information Technology" },
            new Department(){ Id = 4, Name = "Philanthrop"},
            new Department(){ Id = 5, Name = "Marketing"}
        };
        public static readonly Employee[] Employees = new Employee[]
        {
            new Employee( ){ Id = 0, Name="Mark Michaelis", Title = "Chief Computer Nerd",DepartmentId = 0 },
            new Employee( ){ Id = 1, Name="Michael Stokesbary", Title = "Senior Computer Wizard",DepartmentId = 2 },
            new Employee( ){ Id = 2, Name="Brian Jones", Title = "Enterprise Integration Guru",DepartmentId = 2 },
            new Employee( ){ Id = 3, Name="Anne Beard", Title = "HR Director",DepartmentId = 1 },
            new Employee( ){ Id = 4, Name="Pat Dever", Title = "Enterprise Architect",DepartmentId = 3 },
            new Employee( ){ Id = 5, Name="Kevin Bost", Title = "Programmer Extraordinaire",DepartmentId = 2 },
            new Employee( ){ Id = 6, Name="Thomas Heavey", Title = "Software Architect",DepartmentId = 2 },
            new Employee( ){ Id = 7, Name="Eric Edmonds", Title = "Philanthropy Coordinator",DepartmentId = 4 },
        };
    }
}
