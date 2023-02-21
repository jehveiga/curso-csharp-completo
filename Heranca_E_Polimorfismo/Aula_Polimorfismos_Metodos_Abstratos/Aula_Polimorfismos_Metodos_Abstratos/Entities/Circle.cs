using Aula_Polimorfismos_Metodos_Abstratos.Entities.Enums;
using System;

namespace Aula_Polimorfismos_Metodos_Abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
