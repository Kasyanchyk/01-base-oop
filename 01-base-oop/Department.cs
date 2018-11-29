using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_base_oop
{
    class Department
    {
        private List<Manager> managers = new List<Manager>();

        public void AddManager(Manager manager)
        {
            managers.Add(manager);
        }

        public void GiveSalary(Employee employee)
        {
            Console.WriteLine($"{employee.First_name} {employee.Second_name}: got salary: {employee.Salary + employee.Bonus} ");
        }
    }
}
