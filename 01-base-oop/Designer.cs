using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_base_oop
{
    class Designer: Employee
    {
        private double effCoeff;
        public override double Salary => (base.Salary*effCoeff);

        public Designer(string first_name, string second_name, double salary, int experiance, Manager manager, double effCoeff) 
            : base(first_name, second_name, salary,experiance,manager)
        {
            this.effCoeff = effCoeff;
            Bonus = GetBonus();
        }
       
    }
}
