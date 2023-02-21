using System;
using System.IO;
using System.Collections.Generic;

namespace Aula_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\myfolder";

            try
            {
                // ou pode ser usado o IEnumerable<string> no lugar do var para declarar o tipo folders
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // listar as pastas de um diretorio
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // listar os arquivos de um diretorio
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder"); // ou pode ser colocado o caminho completo do diretorio
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
