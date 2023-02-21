using System;

namespace Ex01_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            Console.WriteLine("Digite sua senha: ");
            int senhaDigitada = int.Parse(Console.ReadLine());

            while (senhaDigitada != senha)
            {
                Console.WriteLine("Senha inválida digite novamente: ");
                senhaDigitada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido! ");
        }
    }
}
