using System;
using System.Collections.Generic;

namespace Shapes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Shape> allShapes = new List<Shape> // aina using system collections generic
            {
                new Circle("red", 6), // ympyrälle väri ja säde, ja tehdään sopiva constructori
                new Circle("blue", 2),
                
                new Rectangle("yellow", 2, 3), 
                new Triangle("grey", 2, 3),
            };

            Console.WriteLine("Käydään kaikki muodot läpi:");
            Console.WriteLine();

            foreach (Shape s in allShapes) // käydään allShapes läpi
            {
                Console.WriteLine($"{s.GetInfo()}");
            }

            // Halutaan vain tiettyä tyyppiä
            Console.WriteLine();
            Console.WriteLine("Tulostetaan vain triangle tyyppiset:");

            foreach (Shape s in allShapes) 
            {
                if (s is Triangle) // tarkistetaan onko muuttuja s triangle tyyppinen
                {
                   Console.WriteLine($"{s.GetInfo()}");
                }
            }

            // Sortataan

            Console.WriteLine();
            allShapes.Sort();

            Console.WriteLine("Sortattu lista pinta-alan mukaan:");

            foreach (Shape s in allShapes) // käydään allShapes läpi
            {
                Console.WriteLine($"{s.GetInfo()}");
            }

            /*
            Console.WriteLine("Sortattu lista VÄRIN mukaan:");

            foreach (Shape s in allShapes) // käydään allShapes läpi
            {
                Console.WriteLine($"{s.GetInfo()}");
            }
            */
        }
    }
}
