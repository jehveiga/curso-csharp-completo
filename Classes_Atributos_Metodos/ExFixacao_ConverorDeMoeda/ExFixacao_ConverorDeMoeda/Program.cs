using System;
using System.Globalization;

namespace ExFixacao_ConverorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotacão do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares voçê vai comprar? ");
            double dolaresComprados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calcConversao = ConversorDeMoeda.ConversaoDolar(cotacao, dolaresComprados);

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.CalculaIof(calcConversao).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
