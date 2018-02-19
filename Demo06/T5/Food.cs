using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Food
    {

        public string Name { get; set; }
        public int Energy { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }


        public Food(string name, int energy, DateTime date, DateTime dueDate)
        {
            Name = name;
            Energy = energy;
            Date = date;
            DueDate = dueDate;

        }
        public override string ToString()
        {
            return "Name: " + Name + ", Energy: " + Energy + ", Date: " + Date + ", dueDate: " + DueDate;
        }
    }
}
