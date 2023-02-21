using System;
using System.Globalization
    ;

namespace Ex02_Funcionario_Calculo_Salario_Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine($"Funcionário: {funcionario}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"Funcionário: {funcionario}");

        }
    }
}
