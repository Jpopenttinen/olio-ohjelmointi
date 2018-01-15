using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        private static int MaxSpeed = 200;

        //properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }

        private int speed;
        public int Speed
        {

            get { return speed; }

            set
            {
                if (value <= MaxSpeed) speed = value;
                else speed = MaxSpeed;
            }
        }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }

      
  

        // method to give more speed
        public void Accelerate()
        {
            Speed += 5;
        }

        // method to slow down
        public void Brake()
        {
            Speed -= 5;
        }

        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);
        }

        //constructor
        public Car(string model, string color, double engine, bool fuzzydices, int doorcount)
        {
            Model = model;
            Color = color;
            Engine = engine;
            FuzzyDices = fuzzydices;
            DoorCount = doorcount;
        }


        // destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed.");
        }

    }
}
