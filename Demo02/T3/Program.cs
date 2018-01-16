using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] piste = new string[5];
            int j = 0;
            int[] points = new int[5];
            for (int i = 0; i < piste.Length; i++)
            {
                Console.WriteLine("Give a point: ");
                piste[i] = Console.ReadLine();
                Int32.TryParse(piste[i], out points[i]);

                j = i - 1;
                if (points[i] > points[j])
                {
                    piste[i] = points[]

                }
            }
            

            Console.WriteLine("Numbers are " + luku[4] + "," + luku[3] + "," + luku[2] + "," + luku[1] + "," + luku[0]);


            Console.ReadLine();
        }
    }
}
