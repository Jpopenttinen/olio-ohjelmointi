﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkat
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAnimal animal = new IAnimal(); Not gonna work...

            Cat cat = new Cat();
            cat.Name = "Mirre";
            Console.WriteLine("Here is {0}: {1}", cat.Name, cat.Talk()); // Here is Mirre: Miau!

            Dog dog = new Dog { Name = "Musti" };
            Console.WriteLine("Here is {0}: {1}", dog.Name, dog.Talk()); // Here is Musti: Wuw!

            Console.ReadKey();

        }
    }
}
