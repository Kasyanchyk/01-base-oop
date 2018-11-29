using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_base_oop
{
    class Developer :Employee
    {
        public Developer(string first_name, string second_name, double salary, int experiance, Manager manager) 
            :base(first_name, second_name, salary, experiance, manager)
        {

        }
    }
}
