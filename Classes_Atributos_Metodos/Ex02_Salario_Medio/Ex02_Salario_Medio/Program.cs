using System;
using System.Globalization;

namespace Ex02_Salario_Medio
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaSalario = 0;

            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();


            Console.WriteLine("Digite o nome do funcionário: ");
            func1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o sálario do funcionário: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do funcionário: ");
            func2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o sálario do funcionário: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaSalario = (func1.Salario + func2.Salario) / 2.0;

            Console.WriteLine($"Sálario médio= {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
