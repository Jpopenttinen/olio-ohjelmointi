using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4
{
    class Media
    {

        // Media --> Tekijä, vuosi, tyyppi, nimi
        // Kirja : Media --> kustantaja, sivunro
        // Digi : Media --> tuottaja, nimi, kokonaispituus

        // Elektronik --> Valmistaja, Malli, valmistusvuosi, takuu,

        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }

        public Media(string name, string author, DateTime date, string type)
        {
            Name = name;
            Author = author;
            Date = date;
            Type = type;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Author: " + Author + ", Date: " + Date + ", Type: " + Type;
        }



    }
}
