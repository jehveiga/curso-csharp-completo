using System;


namespace Aula_Calculo_Triangulo
{
    class Triangulo
    {
        // Atributos para efetuar o calculo da área do triangulo
        public double A;
        public double B;
        public double C;

        // Método de calcular área
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }
    }
}
 