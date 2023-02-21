using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_Polimorfismos_Metodos_Abstratos.Entities.Enums;

namespace Aula_Polimorfismos_Metodos_Abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
