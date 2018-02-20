using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5
{
    class Baby : Human
    {
        /*Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. 
         * Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". 
         * Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". 
         * Lisää aikuiselle ominaisuus auto (String). Lisää vauvalle ominaisuus vaippa (String).*/

        public string Diaper { get; set; }
        public Baby(string diaper, string name, int weight, int height)
            : base(name, weight, height)
        {
            Diaper = diaper;
        }
        public override string ToString()
        {
            return base.ToString() + " Diaper: " + Diaper;
        }

        public override void Move()
        {
            Console.WriteLine("Crawl");
        }
    }
}
