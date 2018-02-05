using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_2
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Fridge fridge = new Fridge();

            List<Fridge> fridges = new List<Fridge>();


            List<Shelf> shelfs = new List<Shelf>();
            Shelf shelf = new Shelf();
            shelf.AddProduct();



            fridges.Add(fridge);

            // Shelf.AddProduct();

            Console.WriteLine(shelf);
            foreach (Fridge n in fridges)
            {
                Console.WriteLine(n.ToString());
            }

            Console.ReadLine();

            

            /*Drinks drink = new Drinks(); 
            drink.Size = 4;
            drink.Date = DateTime.Now;
            drink.Name = "Milk";
            Drinks drink2 = new Drinks();
            drink2.Size = 3;
            drink.Date = DateTime.Now;
            drink.Name = "Beeeeer";

            Cheeses cheese = new Cheeses();
            cheese.Shape = "square";
            cheese.Date = DateTime.Now;
            cheese.Name = "Edam";

            Console.WriteLine(drink);


            List<Drinks> drinksus = new List<Drinks>();

            drinksus.Add(drink);
            drinksus.Add(drink2);


            List<Cheeses> cheesessus = new List<Cheeses>();
            cheesessus.Add(cheese);


            foreach (Drinks k in drinksus)
            {
                Console.WriteLine(k.ToString());
            }

            Console.WriteLine("");

            foreach (Cheeses n in cheesessus)
            {
                Console.WriteLine(n.ToString());
            }

            Console.WriteLine("");

            Console.ReadLine();*/
        }
    }
}
