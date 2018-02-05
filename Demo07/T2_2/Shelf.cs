using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_2
{
    class Shelf
    {

        public Product carrot = new Product("carrot", "vegetables");
        public Product milk = new Product();


        public Shelf()
        {
            Product carrot = new Product();
            carrot.Name = "carrot";
            carrot.Type = "vegetables";
            List<Product> products = new List<Product>();
            products.Add(carrot);

            Product milk = new Product();
            milk.Name = "Valio";
            milk.Type = "Milk";

        }

        public void AddProduct()
        {
            List<Product> products = new List<Product>();
            products.Add(carrot);
            products.Add(milk);


            foreach (Product n in products)
            {
                Console.WriteLine(n.ToString());
            }

        }





    }
}
