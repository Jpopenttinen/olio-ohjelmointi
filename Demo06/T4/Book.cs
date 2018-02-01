using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4
{
    class Book : Media
    {
        // Kirja : Media --> kustantaja, sivunro

        public string Publisher { get; set; }
        public int Pages { get; set; }

        public Book(string name, string author, DateTime date, string type, string publisher, int pages)
            :base (name, author, date, type)
        {
            Publisher = publisher;
            Pages = pages;
        }
        public override string ToString()
        {
            return base.ToString() + "Name: " + Name + ", Author: " + Author + ", Date: " + Date + ", Type: " + Type + ", Publisher: " + Publisher + ", Pages: " + Pages;
        }

    }
}
