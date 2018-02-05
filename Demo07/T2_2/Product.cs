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

        public string Type { get; set; }


        public Product()
        {
        }

        public Product(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something!");
        }

        public override string ToString()
        {
            return "Name: " + Name + "Type: " + Type;

        }


    }
}
