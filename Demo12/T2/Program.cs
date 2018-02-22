using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {

            Product milk = new Product("Milk", 4.50);
            Product cheece = new Product("Cheece", 5.00);
            Product orange = new Product("Orange", 1.50);
            Product coffee = new Product("Coffee", 2.50);

            List<Product> listProduct = new List<Product>();

            listProduct.Add(milk);
            listProduct.Add(cheece);
            listProduct.Add(orange);
            listProduct.Add(coffee);

            Console.WriteLine("All Product in your Collection: ");
            foreach (Product i in listProduct)
            {
                Console.WriteLine(i);
            }

        }
    }
}
