﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            InternetConnection conn = new InternetConnection();
            conn.Connect(dog);

            



        }
    }
}
