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
            namespace Jamk.It
    {
        // Dog class
        public class Dog
        {
            // properties
            public string Name { get; set; }
            public Color Color { get; }

            // constructors
            public Dog()
            {
                this.Color = Color.Black;
            }

            public Dog(string name) : base()
            {
                this.Name = name;
            }

            // methods
            public string Growl()
            {
                // some interesting growling action happens here...
                return "Murrr";
            }

            public string Bark(int times)
            {
                // some interesting barking action here...
                string bark = "";
                for (int i = 0; i < times; i++)
                {
                    bark += " vuh ";
                }
                return bark;
            }

        }

        // DogDemo class
        class DogDemo
        {

            // Main method
            static void Main(string[] args)
            {
                // create a new Dog object instance
                Dog myDog = new Dog();

                // dog has different properties
                // property can be readable, writable or even read-oly
                myDog.Name = "Sesse";
                Color color = myDog.Color;

                // dog collection
                Dog yourDog = new Dog("Jekku");
                List<Dog> dogs = new List<Dog>();
                dogs.Add(myDog);
                dogs.Add(yourDog);

                // reference to first dog in collection
                Dog dogBoss = dogs[0];

                // object can have also methods
                Console.WriteLine("My dog {0} is saying {1}", myDog.Name, myDog.Growl());
                Console.WriteLine("Your dog {0} is saying {1}", yourDog.Name, yourDog.Bark(100));

                // object can have different events, but you will learn those later...
            }

        }
    }
}
    }
}
