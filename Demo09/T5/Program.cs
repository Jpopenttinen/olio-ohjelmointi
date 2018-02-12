using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Haetaan tiedosto
            string clubFile = @"C:\Users\Laura\Desktop\Joel Koulu 2017\Olio-ohjelmointi\uusi_2_olio\Demo09\T5\jyp.txt";

            try
            {
                if (File.Exists(clubFile))
                {
                    // Haetaan tiedot
                    string txt = File.ReadAllText(clubFile);
                    string[] line = File.ReadAllLines(clubFile);


                    //Player player = new Player(playNumber, players[1], players[2], players[3], players[4]);

                    List<Player> ListPlayers = new List<Player>();
                    for (int j = 0; j < line.Length - 1; j++)
                    {
                        string[] players = line[j].Split(',');
                        int playNumber;
                        Int32.TryParse(players[0], out playNumber);
                        ListPlayers.Add(new Player(playNumber, players[1], players[2], players[3], players[4]));
                    }
                    


                    Club Jyp = new Club("JYP", "Jyvaskyla", ListPlayers);
                    


                    Console.WriteLine("Club: " + Jyp.Name);
                    Console.WriteLine("City: " + Jyp.City);
                    Console.WriteLine("Players: ");
                    Console.WriteLine("GOALTENDERS: ");
                    foreach (Player m in Jyp.Players)
                    {
                        if (m.Position == "MV")
                        {
                            Console.WriteLine("Number: " + m.Number + " Name: " + m.FirstName + " " + m.LastName + " Shoots: " + m.Shoot);
                        }
                    }
                    Console.WriteLine("DEFENCEMEN: ");
                    foreach (Player m in Jyp.Players)
                    {
                        if (m.Position == "OP" || m.Position == "VP")
                        {
                            Console.WriteLine("Number: " + m.Number + " Name: " + m.FirstName + " " + m.LastName + " Shoots: " + m.Shoot);
                        }
                    }
                    Console.WriteLine("FORWARDS: ");
                    foreach (Player m in Jyp.Players)
                    {
                        if (m.Position == "KH" || m.Position == "OL" || m.Position == "VL")
                        {
                            Console.WriteLine("Number: " + m.Number + " Name: " + m.FirstName + " " + m.LastName + " Shoots: " + m.Shoot);
                        }
                    }

                    


                    //Console.WriteLine("In File {0} is names: \n{1}", clubFile, txt);
                }
                else
                {
                    Console.WriteLine("File {0} cannot found", clubFile);
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
