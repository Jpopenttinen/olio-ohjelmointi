using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Employee : Person
    {
        public Employee(string Name, string Profession, float Salary)
            :base (Name, Profession, Salary)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
