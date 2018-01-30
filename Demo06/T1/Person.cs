using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Person
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public float Salary { get; set; }

        public Person(string name, string profession, float salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Profession: " + Profession + ", Salary: " + Salary ;
        }
    }
}
