using System;

namespace ExArray_Quartos_Alugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            // For para atribuir o Objeto estudante nos quartos 
            for (int i=1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            // For para imprimir os quartos se estiverem ocupados
            for (int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + $": {vect[i]}");
                }
            }
        }
    }
}
