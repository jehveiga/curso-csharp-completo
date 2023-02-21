using System;
using System.IO;

namespace Aula_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\dev\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open); Abrindo arquivo com o caminho passado no parametro e armazenando a varíavel 
                //sr = new StreamReader(fs); sr usado para usar os metodos para manipular o arquivo 
                sr = File.OpenText(path); // funciona da mesma maneira que em cima só que usando o File
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }catch(IOException e)
            {
                Console.WriteLine("An erro accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null) sr.Close(); // fechando o arquivo
                //if (fs != null) fs.Close(); fechando o arquivo
            }
        }
    }
}
