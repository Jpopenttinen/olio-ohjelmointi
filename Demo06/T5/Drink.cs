using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Drink : Food
    {
        public string Type { get; set; }
        public int Capacity { get; set; }

        public Drink(string name, int energy, DateTime date, DateTime dueDate, string type, int capacity)
            : base(name, energy, date, dueDate)
        {
            Type = type;
            Capacity = capacity;
        }
        public override string ToString()
        {
            return base.ToString() + "Type: " + Type + ", Capacity: " + Capacity;
        }

    }
}
