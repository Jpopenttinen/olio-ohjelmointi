using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Boss : Person
    {
        public string Car { get; set; }
        public float SalaryBonus { get; set; }

        public Boss(string Name, string Profession, float Salary, string car, float salaryBonus)
            :base (Name, Profession, Salary)
        {
            Car = car;
            SalaryBonus = salaryBonus;
        }
        public override string ToString()
        {
            return base.ToString() + ", Car: " + Car + ", SalaryBonus: " + SalaryBonus ;
        }

    }
}
