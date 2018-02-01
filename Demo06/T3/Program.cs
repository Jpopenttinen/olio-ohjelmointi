using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {


            Radio Bose = new Radio();
            int ONoff = 1;
            string freqString;
            float freq;
            int volume;
            Bose.Volume = 1;
            while (true)
            {
                Console.WriteLine("If you wish to put Radio on, give 1 (if you wish to shut program give 0): ");
                Int32.TryParse(Console.ReadLine(), out ONoff);

                if (ONoff == 1) { Bose.OnOff = true; }
                else { Bose.OnOff = false; }

                Console.WriteLine("Set the frequency: ");
                freqString = Console.ReadLine();
                //float.Parse("41.00027357629127", CultureInfo.InvariantCulture.NumberFormat
                //freq = (float)Convert.ToDouble(freqString);
                freq = float.Parse(freqString);
                Bose.Frequency = freq;

                Console.WriteLine("Set the volume: ");
                Int32.TryParse(Console.ReadLine(), out volume);
                Bose.Volume = volume; 

                Console.WriteLine(Bose.OnOff);
                Console.WriteLine(Bose.Frequency);
                Console.WriteLine(Bose.Volume);

                Console.ReadLine();
            }

                


        }
    }
}
