using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string names = @"Z:\Olio-ohjelmointi\names.txt";

            try
            {
                if (File.Exists(names))
                {
                    // Haetaan tiedot
                    string txt = File.ReadAllText(names);
                    string[] line = File.ReadAllLines(names);

                    int count = line.Count();
                    int k = 0;
                    foreach (string a in line)
                    {
                        if (a == line[k])
                        {
                            Console.WriteLine(a);
                        }
                        k++;
                    }
                    Console.WriteLine("There where {0} lines", count);
                    Console.WriteLine(txt);
                }
                else
                {
                    Console.WriteLine("File {0} cannot found", names);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            }
        }

    
    
}
