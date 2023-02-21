using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Parametros_RefOut
{
    class Calculator
    {
        // ref aponta para referencia da variavel 
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        //out parecido com ref porem não precisa que a variavel seja iniciada criando uma copia na saida de uma variavel no caso abaixo result
        public static void Triple2(int origin, out int result)
        {
            result = origin * 3; 
        }
    }
}
