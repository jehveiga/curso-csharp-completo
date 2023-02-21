using System;
using System.Collections.Generic;

namespace Aula_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //Add para adicionar um obj na lista sempre ao final
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            // Insert adiciona um obj na lista no indice informado
            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Count informa a contagem da lista total
            Console.WriteLine($"List Count {list.Count}");

            // Find pode ser usado para fazer filtros na lista buscando dados do primeiro obj com a condicao/predicado informada, abaixo exemplo com a expressão lambda como parametro
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s1}");

            // Find pode ser usado para fazer filtros na lista buscando dados do ultimo obj com a condicao/predicado informada, abaixo exemplo com a expressão lambda como parametro
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            // Encontrar a primeira (baseado no número/indice) do elemento da lista que satisfaça um predicado: 
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Fisrt position 'A': {pos1}"); // que seria o "Alex"

            // Encontrar a ultima posição (baseado no número/indice) do elemento da lista que satisfaça um predicado:
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}"); //que seria a "Ana"

            //Filtrar a lista com base em um predicado, no caso ela criará uma nova lista com os dados requeridos:
            List<string> list2 = list.FindAll(x => x.Length == 5); //irá retornar todos obj que tem 5 caracteres no caso "Maria e Marco"
            Console.WriteLine("---------------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Remover elementos da lista, se ele não encontrar o obj informado ele não faz nada:
            list.Remove("Alex"); // No caso irá remover o Alex
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // No caso irá remover todos que contém a letra 'M' em maisculo "Maria e Marco" pelo filtro do predicado informado
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover elementos pela posição dele (numero/indice):
            list.RemoveAt(0); // Irá remover o "Bob que está no indice [0]"
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover elementos de uma faixa: 
            list.RemoveRange(0, 1); // Irá remover a partir do indice informado e quantos objetos serão removidos (indice, quantidade)
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj); 
            }
        }

    }
}
