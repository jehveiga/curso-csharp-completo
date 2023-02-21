using System;

namespace Aula_TopicosEspeciaisVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(z.GetType());
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
