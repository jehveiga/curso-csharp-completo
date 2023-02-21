using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacao_ConverorDeMoeda
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double CalculaIof(double valorConversao)
        {
            return valorConversao += valorConversao * Iof;
        }

        public static double ConversaoDolar(double cotacao, double valor)
        {
            return cotacao * valor;
        }
    }
}
