using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex_Lista_AumentoSalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários vc deseja registrar? ");
            int funcRegistrar = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= funcRegistrar; i++)
            {
                Console.WriteLine($"Funcionário: #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, name, salary));

            }

            Console.Write("Entre com o id do funcionário que será aumentado o salário: ");
            int idFiltro = int.Parse(Console.ReadLine());
            //Pesquisa o funcionário na lista com o id informado acima e armazena na varíavel func
            Funcionario func = funcionarios.Find(x => x.Id == idFiltro);
            if (func != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.IncreaseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("O id informado não existe! ");
            }

            Console.WriteLine();
            Console.WriteLine("Atualização da lista de funcionários: ");
            foreach(Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}
