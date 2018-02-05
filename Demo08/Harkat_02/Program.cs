using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkat_02
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                var persons = new List<Person>();

                persons.Add(new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" });
                persons.Add(new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" });
                persons.Add(new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" });


                Console.WriteLine(persons.ElementAt(0).ToString()); // Kirsi Mainio 010190-111A
                Console.WriteLine(persons[0].ToString()); // Kirsi Mainio 010190-111A

                foreach (Person person in persons)
                {
                    Console.WriteLine(person.ToString());
                }


                Console.ReadLine();

                persons.Sort((x,y) => x.Lastname.CompareTo(y.Lastname));
                foreach (Person person in persons)
                {
                    Console.WriteLine(person.ToString());
                }

                //CompareTo method
                Console.ReadLine();
                persons.Sort();
                foreach (Person person in persons)
                {
                    Console.WriteLine(person.ToString());
                }

                /*var names = new List<String>

                {
                "Anna",
                "Bertil",
                "Camilla",
                "Daavetti"
                };

                //names.ForEach(name => Console.WriteLine($"Hello {name}"));
                names.ForEach(ShowInConsole);
                Console.ReadLine();*/
            }

            Console.ReadLine();
        }

        private static void ShowInConsole(string txt)
        {
            Console.WriteLine(txt);

            
        }

        
        
    }
}
