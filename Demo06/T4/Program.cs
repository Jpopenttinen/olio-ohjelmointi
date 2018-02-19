using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("jokunimi", "Juha Mieto", DateTime.Now, "Book", "Otava", 254);
            Book book2 = new Book("jokunimi2", "Jukka", DateTime.Now, "Book", "Otava", 454);
            Book book3 = new Book("jokunimi3", "Matti", DateTime.Now, "Book", "Otava", 154);

            Digital CD = new Digital("hyvälevy", "HIM",DateTime.Now, "CD", "Antti Tuisku", 4);
            Digital CD2 = new Digital("levy", "Tuoisku",DateTime.Now, "CD", "Antti Tuisku", 4);
            Digital CD3 = new Digital("paraslevy", "Anatude",DateTime.Now, "CD", "Antti Tuisku", 4);

            List<Book> Books = new List<Book>();
            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);

            List<Digital> CDs = new List<Digital>();
            CDs.Add(CD);
            CDs.Add(CD2);
            CDs.Add(CD3);

            foreach (Book i in Books)
            {
                Console.WriteLine("Book {0} from {1}", i.Name, i.Author);
            }
            foreach (Digital j in CDs)
            {
                Console.WriteLine("CD {0} from {1}",j.Name, j.Author);
            }

        }
    }
}
