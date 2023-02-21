using System;
using System.Globalization;

namespace Aula_Array_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Criação do vetor que irão armazenar os produtos informados
            Product[] products = new Product[n];

            // For que irá percorrer o vetor e em cada posição armazenar os dados do objeto produto (nome e preco)
            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products[i] = new Product { Name = nome, Price = preco };
           
            }

            // For para percorrer o vetor e comar o preco dos produtos contidos no vetor
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += products[i].Price;
            }

            // variavel para conter a media do preco somado dos objetos do vetor
            double avg = sum / n;
            Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
