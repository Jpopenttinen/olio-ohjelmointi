using System;
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
            Car datsun = new Car();
            

            datsun.Speed = 100;
            Console.WriteLine(("datsun spees is: ") + datsun.Speed);

            datsun.Speed = 500;
            Console.WriteLine(("datsun spees is: ") + datsun.Speed);

            Console.ReadLine();
        }
    }
}
