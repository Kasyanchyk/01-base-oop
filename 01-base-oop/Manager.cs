using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_base_oop
{
    class Manager : Employee
    {
        public List<Employee> employees = new List<Employee>();

        public Manager(string first_name, string second_name, double salary, int experiance, Manager manager, Department department)
            : base(first_name, second_name, salary, experiance, manager)
        {
            department.AddManager(this);
        }

        public void AddToTeam(Employee employee)
        {
            employees.Add(employee);
            Bonus = UpdateBonus();
        }

        private double UpdateBonus()
        {
            double bonus = 0;
            if (employees.Count > 10)
                bonus+=300;
            else if (employees.Count > 5)
                bonus+=200;

            int count = 0;
            foreach(Employee e in employees)
            {
                if(e is Developer)
                {
                    count++;
                }
            }

            if (count > employees.Count / 2)
                bonus += 0.1 * Salary;

            return bonus+GetBonus();
        }
    }
}
