using System;

namespace Aula_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            //Informa o tamanho da matriz no total
            Console.WriteLine(mat.Length);

            //Informa o tamanho de dimensão da matriz
            Console.WriteLine(mat.Rank);

            //Informa o tamanho de linhas da matriz, conforme o paramatro informado de dimensão (linhas/colunas), no caso abaixo as linhas
            Console.WriteLine(mat.GetLength(0));

            //Informa o tamanho de linhas da matriz, conforme o paramatro informado de dimensão (linhas/colunas), no caso abaixo as colunas
            Console.WriteLine(mat.GetLength(1));


        }
    }
}
