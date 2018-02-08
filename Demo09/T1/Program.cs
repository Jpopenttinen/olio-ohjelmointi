using System;
using System.Collections.Generic;
using System.IO; // Tiedoston käsittelyä varten
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class NamesToFile
    {

        static void Test()
        {
            
            try
            {
                string line;
                string myfile = @"D:\K2593\testi.txt";
                // Luodaan tiedosto
                using (StreamWriter sw = new StreamWriter(myfile))
                {

                
                    // Kysytään käyttäjältä nimet
                    // Kirjoitetaan nimet tiedostoon
                    do
                    {
                        Console.WriteLine("Give a name (empty stops): ");
                        line = Console.ReadLine();
                        if (line.Length > 0)
                        {
                            sw.WriteLine(line);
                        }
                    } while (line.Length > 0);
                sw.Close();
                }
                if (File.Exists(myfile))
                {
                    // Näytetään nimet
                    string txt = File.ReadAllText(myfile);
                    Console.WriteLine("In File {0} is names: \n{1}", myfile, txt);
                }
                else
                {
                    Console.WriteLine("File {0} cannot found", myfile);
                }
                // Avataan tiedosto lukua varten

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
