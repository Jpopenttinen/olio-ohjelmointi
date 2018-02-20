using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5
{
    class Adult : Human
    {
        public string Car { get; set; }
        public Adult(string car, string name, int weight, int height)
            : base(name, weight, height)
        {
            Car = car;
        }
        public override string ToString()
        {
            return base.ToString() + " Car: " + Car;
        }
        public override void Move()
        {
            Console.WriteLine("Walk");
        }
    }
}
