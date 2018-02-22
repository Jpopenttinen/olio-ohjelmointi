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
            List<Fisherman> fishermen = new List<Fisherman>();
            List<Fish> listOfFish = new List<Fish>();

            Dictionary<Fisherman, List<Fish>> fishRegistery = new Dictionary<Fisherman, List<Fish>>();
            int rounds = 0;
            while (rounds < 2)
            {
                fishermen = Program.AddFisherman(fishermen);
                Console.WriteLine("Give a name whom you want to add Fish: (eg. 'jukk' = jukka)");
                string line = Console.ReadLine();
                var foo = fishermen.FirstOrDefault(x => x.Name.StartsWith(line));
                

                Console.WriteLine("Give a location where you got the fishes: (placename, city)");
                string location = Console.ReadLine();
                string[] locationSplit = location.Split(',');
                Location loc = new Location(locationSplit[0], locationSplit[1]);

                listOfFish = Program.AddFish(loc);
                foreach (Fisherman a in fishermen)
                {
                    if (a.Name == foo.Name)
                    {
                        if (fishRegistery.ContainsKey(a))
                            fishRegistery[a] = listOfFish;        
                        else
                            fishRegistery.Add(a, listOfFish);
                    }

                    Console.WriteLine("A new fisherman added to Fish-register: ");
                    Console.WriteLine("- Fisherman: {0} Phone {1}", a.Name, a.Phonenumber);
                }
                rounds++;
            }
            foreach (KeyValuePair<Fisherman, List<Fish>> k in fishRegistery)
            {

                //Console.WriteLine("Key = {0}, Value = {1}", k.Key, k.Value);
                Fisherman fisherman = k.Key;
                Console.WriteLine(fisherman);
                foreach (Fish m in k.Value)
                {
                    m.PrintFishes();
                }
            }
            /*var myList = fishRegistery.ToList();

            myList.Sort((pair1, pair2) => pair1.Value[2].CompareTo(pair2.Value));*/
        }

        public static List<Fisherman> AddFisherman(List<Fisherman> listFishrmn)
        {
            List<Fisherman> listFishermen = new List<Fisherman>();
            listFishermen = listFishrmn;

            while (true)
            {
                Console.WriteLine("Give a Fisherman (name, phonenumber): (exit with empty line)");
                string line = Console.ReadLine();
                if (line == "")
                {
                    break;
                }
                else
                {
                    string[] lineSplit = line.Split(',');
                    listFishermen.Add(new Fisherman(lineSplit[0], lineSplit[1]));
                    
                }
                
            }

            return listFishermen;
        }

        public static List<Fish> AddFish(Location loca)
        {
            List<Fish> fishes = new List<Fish>();

            while (true)
            {
                Console.WriteLine("Give a fish (spiece, lenght(cm), weight(kg)): (exit with empty line)");
                string line = Console.ReadLine();
                if (line == "")
                {
                    break;
                }
                else
                {
                    string[] lineSplit = line.Split(',');
                    int lenght;
                    int weight;
                    int.TryParse(lineSplit[1], out lenght);
                    int.TryParse(lineSplit[2], out weight);

                    fishes.Add(new Fish(lineSplit[0], lenght, weight, loca));
                }
            }
            return fishes;
        }
    }
}
