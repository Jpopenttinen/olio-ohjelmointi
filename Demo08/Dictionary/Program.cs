using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // create persons collection
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            // create persons
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person person2 = new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" };
            Person person3 = new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" };
            // add persons to collection
            persons.Add(person1.SocialSecurityNumber, person1);
            persons.Add(person2.SocialSecurityNumber, person2);
            persons.Add(person3.SocialSecurityNumber, person3);
            // find person with key
            string key = "020292-222A";

            Person found;
            if (persons.TryGetValue(key, out found))
            {
                Console.WriteLine("Person with social security number {0} is {1}.", key, found.Firstname);
            }
            else
            {
                Console.WriteLine("Person with social security number NOT FOUND");

            }

            foreach (string k in persons.Keys)
            {
                Console.WriteLine(k.ToString());
            }

            foreach (Person person in persons.Values)
            {
                Console.WriteLine(person.ToString());
            }

            foreach (KeyValuePair<string, Person> kvp in persons)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);

            }
            /*
            if (persons.ContainsKey(key))
            {
                Console.WriteLine("Person with social security number {0} is {1}.", key, persons[key].Firstname);
                // output
                //  Person with social security number 020292-222A is Matti.
            }
            */

            // remove object
            if (persons.ContainsKey("020292-222A"))
            {
                persons.Remove("020292-222A");
            }

            // size
            Console.WriteLine("Collection size is {0}", persons.Count); // 2

            Console.ReadLine();


        }
    }
}
