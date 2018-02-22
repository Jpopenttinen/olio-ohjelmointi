using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1
{
    class Dice
    {
        /*Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku 
         * jokaisella heittokerralla. Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa 
         * kerran ja tulosta nopan luku. Toteuta tämän jälkeen ohjelma siten, että kysyt käyttäjältä heittojen määrän. 
         * Heitä noppaa ja tulosta heittojen lukujen keskiarvo.*/

        Random randomNum = new Random();

        public double CreateRndNumber()
        {
            int numb = randomNum.Next(1, 7);

            return Convert.ToDouble(numb);
        }

    }
}
