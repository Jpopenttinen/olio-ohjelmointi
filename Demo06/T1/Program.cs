using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp_001 = new Employee("Matti", "Rekkakuski", 2500);
            Employee emp_002 = new Employee("Kalle", "Myyjä", 3500);
            Employee emp_003 = new Employee("Anna", "Sihteeri", 2500);
            Employee emp_004 = new Employee("Janne", "Ohjelmoija", 4200);

            Boss boss_001 = new Boss("Janne", "Ohjelmoija", 5200, "Nissa", 200);

            List<Employee> lstdEmployees = new List<Employee>();

            lstdEmployees.Add(emp_001);
            lstdEmployees.Add(emp_002);
            lstdEmployees.Add(emp_003);
            lstdEmployees.Add(emp_004);

            Console.WriteLine("Employees:");
            Console.WriteLine("");

            foreach (Employee k in lstdEmployees)
            {
                Console.WriteLine(k.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("Bosses:");
            Console.WriteLine("");

            List<Boss> lstdBosses = new List<Boss>();
            lstdBosses.Add(boss_001);

            foreach (Boss n in lstdBosses)
            {
                Console.WriteLine(n.ToString());
            }

            Console.ReadLine();
        }
    }
}
