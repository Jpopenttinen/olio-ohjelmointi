﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // a lot of different animals in a list
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Chicken());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Chicken());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Chicken());
            // virtual method talk is invoked on each of the derived classes, not the base class. 
            foreach (Animal animal in animals)
            {
                // note we can handle this with one talk-method!
                animal.Talk();
                
                if (animal is Chicken)
                {
                    Console.WriteLine("This one is a chichen");
                    Chicken chichen = animal as Chicken;
                    chichen.Talk();
                }

            }
            Console.ReadLine();
        }
    }
}
