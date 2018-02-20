using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5
{
    abstract class Mammal
    {
        /*Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, 
         * jonka toteutus on jätetty toteuttamatta (abstrakti metodi).*/

        public abstract int Age { get; }
        public abstract void Move();
    }
}
