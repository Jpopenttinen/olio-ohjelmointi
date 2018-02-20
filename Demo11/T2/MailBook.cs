using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace T2
{
    class MailBook
    {

        string names = @"Z:\Olio-ohjelmointi\tutut.csv";

        List<Friend> Frendit = new List<Friend>();

        public List<Friend> GetEmails()
        {
            try
            {
                if (File.Exists(names))
                {
                    //string txt = File.ReadAllText(names);
                    string[] line = File.ReadAllLines(names);
                    int count = line.Count();
                    Dictionary<string, string> listNames = new Dictionary<string, string>();

                    for (int i = 0; i < line.Length; i++)
                    {
                        string[] sepLines = line[i].Split(';'); // Splits lines to two separate Strings from semicolon
                        listNames.Add(sepLines[0], sepLines[1]); // Adds first string as dict key and second as value
                    }
                    foreach (KeyValuePair<string,string> k in listNames)
                    {
                        Frendit.Add(new Friend(k.Key, k.Value));
                    }
                    
                    



                    /*Dictionary<string, int> listNames = new Dictionary<string, int>();


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
                    }*/
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

            return Frendit;
        }
    }
}
