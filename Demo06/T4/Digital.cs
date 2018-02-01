using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4
{
    class Digital : Media
    {


        // Media --> Tekijä, vuosi, tyyppi, nimi
        // Kirja : Media --> kustantaja, sivunro
        // Digi : Media --> tuottaja, nimi, kokonaispituus

        // Elektronik --> Valmistaja, Malli, valmistusvuosi, takuu,

        public string Produser { get; set; }
        public int CDLenght { get; set; }

        public Digital(string name, string author, DateTime date, string type, string produser, int cDLenght)
            :base (name, author, date, type)
        {
            Produser = produser;
            CDLenght = cDLenght;
        }
        public override string ToString()
        {
            return base.ToString() + "Name: " + Name + ", Author: " + Author + ", Date: " + Date + ", Type: " + Type + ", Produser: " + Produser + ", CDLenght: " + CDLenght;
        }

    }
}
