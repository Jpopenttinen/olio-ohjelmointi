using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Item pen = new Item("Pen1", 4, "Pen");
            Item gum = new Item("Gum1", 2, "Gum");
            Item phone = new Item("iPhone", 1, "Phone");
            Item wallet = new Item("WallE", 1, "Wallet");

            List<Item> itemList = new List<Item>();
            itemList.Add(pen);
            itemList.Add(gum);
            itemList.Add(phone);
            itemList.Add(wallet);

            Basket basketRound = new Basket();
            basketRound.AddItems("Round", itemList);
        }
    }
}
