using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Boat : Vehicle
    {
        // veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä löytyy.


        public string BoatType { get; set; }
        public int Seats { get; set; }


        public Boat(string name, string model, int year, string color, string boatType, int seats )
            :base (name, model, year, color)
        {
            BoatType = boatType;
            Seats = seats;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Year: " + Year + ", Color: " + Color + ", BoatType: " + BoatType + ", Seats: " + Seats;

        }

    }
}
