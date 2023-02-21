using Aula_Polimorfismos_Metodos_Abstratos.Entities;
using Aula_Polimorfismos_Metodos_Abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_Polimorfismos_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the bnumber of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (op == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }

            }

            Console.WriteLine();
                Console.WriteLine("SHAPE AREAS: ");
                foreach(Shape shape in shapes)
                {
                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture)); 
                }
                
        }
    }
}
