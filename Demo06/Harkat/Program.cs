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
            

            Circle circle = new Circle();
            circle.Name = "My Circle";
            circle.Draw(); // "Draw Circle!"

            Square square = new Square();
            square.Name = "My Square";
            square.Draw(); // "Draw Square!"

            // create a list to store objects
            List<Shape> drawingObjects = new List<Shape>();
            // use polymorphis to store objects
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());

            Console.WriteLine("Loop through all drawing objects in a list:");
            foreach (Shape drawingObject in drawingObjects)
            {
                drawingObject.Draw(); // "Draw Circle!" "Draw Square!" ...
            }
            Console.ReadLine();

        }
    }
}
