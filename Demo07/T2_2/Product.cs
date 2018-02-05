using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_2
{
    class Product
    {

        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Product()
        {
        }

        public Product(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something!");
        }

        public override string ToString()
        {
            return "Name: " + Name + "Date: " + Date;

        }


        //public abstract void ();

    }
}
