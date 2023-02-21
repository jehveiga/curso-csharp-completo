using System;

namespace Aula_Operacoes_Com_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dAtual = DateTime.Now;
            DateTime d = new DateTime(2022, 1, 14, 13, 45, 58);

            //Adicionando 2 horas a varíavel
            DateTime d2 = d.AddHours(2);
            //Adicionando 3 minutos a varíavel
            DateTime d3 = d.AddMinutes(3);
            //Adicionando 7 dias a varíavel
            DateTime d4 = dAtual.AddDays(7);
            //Calcula a diferença entre duas datas trazendo a duração entre os intervalos
            TimeSpan t = dAtual.Subtract(d);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(t);
        }
    }
}
