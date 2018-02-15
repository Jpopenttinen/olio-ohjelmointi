using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace T4
{
    class Program
    {
        static void Test()
        {

            try
            {
                string line;
                string floats = @"Z:\Olio-ohjelmointi\float.txt";
                string integers = @"Z:\Olio-ohjelmointi\int.txt";

                // Luodaan tiedosto

                    // Kysytään käyttäjältä nimet
                    // Kirjoitetaan nimet tiedostoon
                    do
                    {
                        Console.WriteLine("Give a number (empty stops): ");
                        line = Console.ReadLine();
                        if (line.Length > 0)
                        {
                            if (line.ToLower().Contains(','))
                            {
                                if (!File.Exists(floats))
                                {
                                    using (StreamWriter sw1 = File.CreateText(floats))
                                    {
                                        sw1.WriteLine(line);
                                        sw1.Close();
                                    }
                                }
                                using (StreamWriter sw1 = File.AppendText(floats))
                                {
                                    sw1.WriteLine(line);
                                    sw1.Close();
                                }
                            }
                            else
                            {
                                if (!File.Exists(integers))
                                {
                                    using (StreamWriter sw2 = File.CreateText(integers))
                                    {
                                        sw2.WriteLine(line);
                                        sw2.Close();
                                    }
                                }
                                using (StreamWriter sw2 = File.AppendText(integers))
                                {
                                    sw2.WriteLine(line);
                                    sw2.Close();
                                }
                            }
                        }

                        
                    } while (line.Length > 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}

