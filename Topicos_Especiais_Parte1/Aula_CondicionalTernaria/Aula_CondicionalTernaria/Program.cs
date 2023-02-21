using System;
using System.Globalization;

namespace Aula_CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Expressão condicional ternária(pode ser usado no sistema diferente de if/else)
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}
