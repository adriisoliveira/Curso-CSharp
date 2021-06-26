using Abstratas2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Abstratas2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("= = = = WELCOME = = = =");
            Console.WriteLine();
            Console.Write("Enter the nummber of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c): ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                var cor = Console.ReadLine();
                Color color = (Color)Enum.Parse(typeof(Color), cor);

                if (shape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double heiht = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(width,heiht,color));
                }
                else if( shape == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(color, radius));

                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape sh in shapes)
            {
                Console.WriteLine(sh.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
