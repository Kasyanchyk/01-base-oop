using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_base_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            Employee manager1 = new Manager("manager1Name", "manager1Surname", 500, 6, null, department);
            Employee manager2 = new Manager("manager2Name ", "manager2Surname", 500, 3, null, department);
            Employee manager3 = new Manager("manager3Name", "manager3Surname", 500, 1, null, department);

            //Team 1
            Employee designer1 = new Designer("designer1Name", "designer1Surname", 300, 1, (Manager)manager1, 0.5);
            Employee designer2 = new Designer("designer2Name", "designer2Surname", 300, 3, (Manager)manager1, 0.6);
            //Designer designer3 = new Designer("designer3Name", "designer3Surname", 300, 4, manager1, 0.7);
            //Designer designer4 = new Designer("designer4Name", "designer4Surname", 300, 6, manager1, 0.8);
            Employee developer1 = new Developer("developer1Name", "developer1Surname", 400, 1, (Manager)manager1);
            Employee developer2 = new Developer("developer2Name", "developer2Surname", 400, 3, (Manager)manager1);
            Employee developer3 = new Developer("developer3Name", "developer3Surname", 400, 6, (Manager)manager1);
            Employee developer4 = new Developer("developer3Name", "developer3Surname", 400, 6, (Manager)manager1);

            department.GiveSalary(manager1);
            department.GiveSalary(designer1);
            department.GiveSalary(designer2);
            //department.GiveSalary(designer3);
            //department.GiveSalary(designer4);
            department.GiveSalary(developer1);
            department.GiveSalary(developer2);
            department.GiveSalary(developer3);
        }
    }
}
