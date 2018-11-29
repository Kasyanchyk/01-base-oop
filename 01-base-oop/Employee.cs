using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_base_oop
{
    abstract class Employee
    {
        public string First_name { get; }

        public string Second_name { get; }

        public virtual double Salary { get; }

        public int Experiance { get; }

        protected Manager Manager { get; }

        public double Bonus { get; set; }

        public Employee(string first_name, string second_name, double salary, int experiance, Manager manager)
        {
            First_name = first_name;
            Second_name = second_name;
            Salary = salary;
            Experiance = experiance;
            Manager = manager;
            Bonus = GetBonus();
            if (manager != null)
                manager.AddToTeam(this);
        }

        protected double GetBonus()
        {
            if (Experiance > 5)
                return Salary * 0.2 + 500;
            else if (Experiance > 2)
                return 200;
            else
                return 0;
        }

        public override string ToString()
        {
            if (Manager != null)
                return $"{First_name} {Second_name}, manager:{Manager.Second_name}, experiance: {Experiance}";
            else
                return $"{First_name} {Second_name}, experiance: {Experiance}";
        }
    }
}
