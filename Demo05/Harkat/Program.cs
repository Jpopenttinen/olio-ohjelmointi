using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkat
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Address = "torikatu 1";
            person.Age = 30;
            person.PhoneNumber = "020-12345678";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher();
            teacher.FirstName = "Teppo";
            teacher.LastName = "Konsoli";
            teacher.Address = "piippukatu 2";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D100";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Minna", "Husso", "J9090");
            student.Address = "kilju 3";
            student.Age = 20;
            student.PhoneNumber = "040-12345678";
            Console.WriteLine(student.ToString());

            List<Person> people = new List<Person>();

            for (int i=0; i<20; i++)
            {
                if (i < 5)
                {
                    people.Add(new Person());
                }
                else if (i < 12)
                {
                    people.Add(new Teacher());
                }
                else
                {
                    people.Add(new Student());
                }

            }

            foreach(Person person2 in people)
            {
                Console.WriteLine(person2.ToString());
            }


            person.PersonMethod(); // This method belongs to Person!
            teacher.PersonMethod(); // This method belongs to Person! (derived class can use it!)
            teacher.TeacherMethod(); // This method belongs to Teacher!
            student.PersonMethod(); // This method belongs to Person! (derived class can use it!)
            student.StudentMethod(); // This method belongs to Student!

            Console.ReadLine();
        }
    }
}
