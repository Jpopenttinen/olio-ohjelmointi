using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                
                double temp = TemperatureConverter.FahrenheitToCelsius(200);

                // create a one car instance
                Car datsun = new Car("Datsun 100", "red", 1.0, true, 2);
                Car porsche = new Car("Porche 911 RS3", "silver", 3, false, 2);
                Car toyota = new Car("Toyota Avensis", "grey", 1.8, false, 5);


                datsun.Speed = 100;
                porsche.Speed = 280;
                toyota.Speed = 160;

                // display car data
                datsun.PrintData();
                porsche.PrintData();
                toyota.PrintData();
                Console.ReadLine();
                // accelerate, change car's speed value
                datsun.Accelerate();
                // display car data again, notice changed speed value!
                datsun.PrintData();
                Console.ReadLine();
            }

        }
    }
}
