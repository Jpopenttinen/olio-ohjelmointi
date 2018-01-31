using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Name:Jopo Model:Street ModelYear:2016 Color:Blue GearWheels:False Gear Name:
            // Name:Yamaha Model:Model 1000 ModelYear:2010 Color:Yellow SeatCount:5 BoatType:Motorboat


            Bike bike_001 = new Bike("Jopo", "Street", 2016, "Blue", false, "Shimano");
            Bike bike_002 = new Bike("Tunturi", "Mountain", 2017, "Green", true, "Shimano");
            Bike bike_003 = new Bike("Kona", "CC", 2015, "Light Green", true, "Shimano");
            Bike bike_004 = new Bike("Kona", "Street", 2013, "White", true, "Shimano");

            Boat boat_001 = new Boat("Yamaha", ":Model 1000", 2010, "Yellow", "Motorboat", 5);

            List<Bike> lstdBike = new List<Bike>();

            lstdBike.Add(bike_001);
            lstdBike.Add(bike_002);
            lstdBike.Add(bike_003);
            lstdBike.Add(bike_004);

            Console.WriteLine("Bikes:");
            Console.WriteLine("");

            foreach (Bike k in lstdBike)
            {
                Console.WriteLine(k.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("Boats:");
            Console.WriteLine("");

            List<Boat> lstdBoats = new List<Boat>();
            lstdBoats.Add(boat_001);

            foreach (Boat n in lstdBoats)
            {
                Console.WriteLine(n.ToString());
            }

            Console.ReadLine();
        }
    }
}
