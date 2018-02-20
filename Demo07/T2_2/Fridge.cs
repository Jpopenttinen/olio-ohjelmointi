using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_2
{
    class Fridge
    {

        public Shelf ShelfTop = new Shelf();
        public Shelf ShelfBottom = new Shelf();

        public void AddShelf()
        {
            Console.WriteLine("There is a following items in the Top shelf: ");
            Console.WriteLine(" ");
            ShelfTop.AddProduct();
            Console.WriteLine("There is a following items in the Top shelf: ");
            Console.WriteLine(" ");
            ShelfBottom.AddProduct();

        }
    }
}
