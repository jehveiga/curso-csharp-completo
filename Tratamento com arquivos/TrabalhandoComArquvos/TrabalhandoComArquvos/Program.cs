using System;
using System.IO;

namespace TrabalhandoComArquvos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\dev\file1.txt";
            string targetPath = @"c:\dev\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // copia o conteudo do objeto que foi passado a varíavel que contem o arquivo como parametro e cria um outro arquivo com a copia do primeiro
                string[] lines = File.ReadAllLines(sourcePath); // guarda o conteudo lido do arquivo no vetor instanciado de string
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
