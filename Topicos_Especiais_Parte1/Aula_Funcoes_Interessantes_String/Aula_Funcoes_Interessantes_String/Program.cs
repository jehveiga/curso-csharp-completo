using System;

namespace Aula_Funcoes_Interessantes_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            //O texto ficará tudo em maiusculo
            string s1 = original.ToUpper();
            //O texto ficará tudo em minusculo
            string s2 = original.ToLower();
            //Tira os espaços em brancos (inicio e fim) da string
            string s3 = original.Trim();
            //Irá fazer uma procura na string, retornando o indice do filtro informado na primeira ocorrência
            int n1 = original.IndexOf("bc");
            //Irá fazer uma procura na string, retornando um indice do filtro informado na última ocorrência
            int n2 = original.LastIndexOf("bc");
            //Irá fazer o recorte da string apartir do informe do (indice) para recortar
            string s4 = original.Substring(3);
            //Irá fazer o recorte da string apartir do informe do (indice) para recortar e do tamanho de quantos caracteres
            string s5 = original.Substring(3, 5);
            //Para efetuar a substituição de valores de caracter, fazendo a troca (valor, troca)
            string s6 = original.Replace('a', 'x');
            //Para efetuar a substituição de valores de string, fazendo a troca (valor, troca)
            string s7 = original.Replace("abc", "xy");
            //Verifica se o valor da string está vazio
            bool b1 = String.IsNullOrEmpty(original);
            //Verifica se o valor da string está vazio ou tem somente espaços em brancos
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToUpper: -{s1}-");
            Console.WriteLine($"ToLower: -{s2}-");
            Console.WriteLine($"Trim: -{s3}-");
            Console.WriteLine($"IndexOf('bc'): -{n1}-");
            Console.WriteLine($"LastIndexOf('bc'): -{n2}-");
            Console.WriteLine($"Substring(3): -{s4}-");
            Console.WriteLine($"Substring(3, 5): -{s5}-");
            Console.WriteLine($"Replace('a', 'x'): -{s6}-");
            Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
            Console.WriteLine($"IsNullOrEmpty: -{b1}-");
            Console.WriteLine($"IsNullOrEmpty: -{b2}-");

        }
    }
}
