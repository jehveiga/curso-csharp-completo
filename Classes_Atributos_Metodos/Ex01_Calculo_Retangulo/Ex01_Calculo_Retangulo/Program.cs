using System;
using System.Globalization;

namespace Ex01_Calculo_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
