﻿using System;
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
            while (true)
            {
                ItMath.TestiPeti();

                if (ItMath.TestiPeti() == 1)
                {
                    break;
                }
                
            }
            
        }
    }
}
