﻿using System;

namespace Aula_Encapsulamento_UsandoPropriedade
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);


            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
