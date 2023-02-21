using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Aluno_Calculo_Media
{
    class Aluno
    {
        public string Nome;
        public double NotaA, NotaB, NotaC;
        

        public double NotaFinal()
        {
            return NotaA + NotaB + NotaC;
        }

        public bool Aprovado()
        {
            if(NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }

    }
}
