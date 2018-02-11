using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Kalle", "Mattila", "TTV17S", 1);
            Student stud2 = new Student("Antti", "Kallela", "TTV13S", 2);
            Student stud3 = new Student("Anni", "Nakkila", "TTV15S", 3);
            Student stud4 = new Student("Manta", "Jaakkola", "TTV14S", 4);

            List<Student> Students = new List<Student>();

            Students.Add(stud1);
            Students.Add(stud2);
            Students.Add(stud3);
            Students.Add(stud4);

            bool result1 = true;

            while (true)
            {
                int keepgoing;
                int aida;

                Console.WriteLine("Give data of a new student: ");
                Console.WriteLine("Firstname: ");
                string fName = Console.ReadLine();
                Console.WriteLine("Lastname: ");
                string lName = Console.ReadLine();
                Console.WriteLine("Group: ");
                string group = Console.ReadLine();


                
                while (true)
                {
                    Console.WriteLine("AidaID: ");
                    Int32.TryParse(Console.ReadLine(), out aida);

                    foreach (Student a in Students)
                    {
                        if (a.AsioID == aida)
                        {
                            Console.WriteLine("Given AidaID exists already. Give a proper AidaId: ");
                            result1 = false;
                            break;
                        }
                        else { result1 = true; }
                    }
                    if (result1 == true)
                    {
                        break;
                    }
                }
                Students.Add(new Student(fName, lName, group, aida));

                Console.WriteLine("Add another one? Press 1. Wish to leave already? Press 2.: ");
                Int32.TryParse(Console.ReadLine(), out keepgoing);
                if (keepgoing == 2) { break; }
            }

            foreach (Student n in Students)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

        }
    }
}
