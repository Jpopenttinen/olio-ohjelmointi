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

            string[] luku = new string[5];

            for (int i = 0; i < luku.Length; i++)
            {
                Console.WriteLine("Give a number: ");
                luku[i] = Console.ReadLine();
            }

            Console.WriteLine(luku[0], luku[1], luku[2], luku[3], luku[4]);


            Console.ReadLine();


        }
    }
}
