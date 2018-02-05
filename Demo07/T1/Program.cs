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

            Vehicle Porche = new Vehicle("Porsche", "911");

            Wheel Nokia = new Wheel("Nokia", "Hakkapelliitta", "205R16");

            Vehicle Ducati = new Vehicle("Ducati","Diavel");

            Wheel Mic1 = new Wheel("MIC", "Pilot", "160R17");

            Wheel Mic2 = new Wheel("MIC", "Pilot", "140R16");


            // Porsche

            List<Wheel> lstdWheelP = new List<Wheel>();

            lstdWheelP.Add(Nokia);
            lstdWheelP.Add(Nokia);
            lstdWheelP.Add(Nokia);
            lstdWheelP.Add(Nokia);

            Console.WriteLine("Vehicle name: " + Porche);
            Console.WriteLine("Tyres:");
            foreach (Wheel k in lstdWheelP)
            {
                Console.WriteLine(k.ToString());
            }

            Console.WriteLine("");

            // Ducati

            List<Wheel> lstdWheelD = new List<Wheel>();

            lstdWheelD.Add(Mic1);
            lstdWheelD.Add(Mic2);

            Console.WriteLine("Vehicle name: " + Ducati);
            Console.WriteLine("Tyres:");
            foreach (Wheel n in lstdWheelD)
            {
                Console.WriteLine(n.ToString());
            }

            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
