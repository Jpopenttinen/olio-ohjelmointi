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
