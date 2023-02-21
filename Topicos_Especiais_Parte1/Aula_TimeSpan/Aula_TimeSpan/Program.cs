using System;

namespace Aula_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representa um intervalo de tempo
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            //Cria um objeto do tipo TimeSpan zerado
            TimeSpan t2 = new TimeSpan();

            Console.WriteLine(t2);

            //Gerando um TimeSpan de 01:30 com a conversão de ticks
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);

            //Gerando um TimeSpan padrão com hora, min, seg
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t4);

            //Gerando um TimeSpan com dia, hora, min, seg
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t5);

            //Gerando um TimeSpan com dia, hora, min, seg, miliseg
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t6);

            //Gerando um Time Span definindo o filtro que quiser abaixo seria um dia e meio
            TimeSpan t7 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t7);

            //Gerando um Time Span definindo o filtro que quiser abaixo seria uma hora e trinta min
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t8);

            //Gerando um Time Span definindo o filtro que quiser abaixo seria um min e trinta seg
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t9);

            //Gerando um Time Span definindo o filtro que quiser abaixo seria um seg e trinta mileseg
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t10);

            //Gerando um Time Span definindo o filtro que quiser abaixo seria um mileseg
            TimeSpan t11 = TimeSpan.FromSeconds(1);
            Console.WriteLine(t11);

            //Gerando um Time Span definindo o filtro que quiser abaixo seria em ticks(cada ticks 100 nanosegundos)
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t12);

        }
    }
}
