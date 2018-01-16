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
            int rivi = 0;
            int luku1 = 0;
            Console.WriteLine("Give a number: ");
            luku1 = Convert.ToInt32(Console.ReadLine());

                for (; luku1 > 0;)
                {
                    rivi++;
                    string rivitys = new string('*', rivi);
                    Console.WriteLine(rivitys);
                    luku1--;
                }

            
            Console.ReadLine();



            /*int luku1;
            int rivi = 0;
            int sivu = 0;


            cout << "Anna luku välillä 1-9: ";
            cin >> luku1;
            int rivitys = luku1;


            while (rivitys > 0)
            {
                rivi++;
                //cout << rivi;
                rivitys--;
                int rivikrt = rivi;

                while (rivikrt > 0)
                {
                    cout << rivi;
                    rivikrt--;

                }
                cout << "\n";

            }*/


        }

    }
}
