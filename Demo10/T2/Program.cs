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

                    Dictionary<string, int> listNames = new Dictionary<string, int>();

                    for (int i = 0; i < line.Length - 1; i++)
                    {
                        int nameCount = 0;
                        for (int j = 0; j < line.Length - 1; j++)
                        {   
                            if(line[i] == line[j])
                            {
                                nameCount++;
                                //line = line.Where(val => val != line[j]).ToArray();
                            }
                        }
                        //Checks if Key exists already and if not, add key and value
                        if (!listNames.ContainsKey(line[i]))
                        {
                            listNames.Add(line[i], nameCount);
                        }
                    }

                    int countNm = listNames.Keys.Count;
                    Console.WriteLine("There where {0} lines and {1} names", count, countNm);
                    foreach (KeyValuePair<string, int> a in listNames)
                    {
                        Console.WriteLine("Name {0} appears {1} times", a.Key, a.Value);
                    }

                    // TEHTÄVÄ 3
                    Console.WriteLine("");
                    Console.WriteLine("TASK 3: \n");

                    var list = listNames.Keys.ToList();
                    list.Sort();
                    foreach (var key in list)
                    {
                        Console.WriteLine("Name {0} appears {1} times", key, listNames[key]);
                    }
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
