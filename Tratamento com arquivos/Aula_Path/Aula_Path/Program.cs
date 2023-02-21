using System;
using System.IO;

namespace Aula_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\myfolder\file1.txt";

            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"Path.PathSeparator: {Path.PathSeparator}");
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"Path.GetFileName: {Path.GetFileName(path)}");
            Console.WriteLine($"Path.GetFileNameWithoutExtension:  {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"Path.GetExtension: {Path.GetExtension(path)}");
            Console.WriteLine($"Path.GetFullPath: {Path.GetFullPath(path)}");
            Console.WriteLine($"Path.GetTempPath: {Path.GetTempPath()}");
        }
    }
}
