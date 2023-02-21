using System;
using System.Globalization;

namespace ExDeposito_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.WriteLine("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entra com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");

            char opcaoDep = char.Parse(Console.ReadLine());

            if(opcaoDep == 's' || opcaoDep == 'S')
            {
                Console.WriteLine("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numero, titular, saldo);
                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(contaBancaria);
            }
            else
            {
                contaBancaria = new ContaBancaria(numero, titular);
                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(contaBancaria);
            }

            Console.WriteLine("Entra com o valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            contaBancaria.Deposito(valorDep);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine("Entra com o valor para saque: ");
            double valorSaq = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            contaBancaria.Saque(valorSaq);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);


        }
    }
}
