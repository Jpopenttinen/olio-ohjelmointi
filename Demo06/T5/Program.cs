using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime manifactured = new DateTime(2014, 6, 14, 6, 32, 0);
            DateTime dueDay = new DateTime(2015, 4, 17, 6, 32, 0);

            Drink Juiissi = new Drink("Juissi", 200, manifactured, dueDay,"Juice", 2);


            Console.WriteLine("Drink: {0}, {1}, {2}, {3}, {4}, {5}", Juiissi.Name, Juiissi.Capacity, Juiissi.Energy, Juiissi.Type, Juiissi.Date, Juiissi.DueDate);


        }
    }
}
