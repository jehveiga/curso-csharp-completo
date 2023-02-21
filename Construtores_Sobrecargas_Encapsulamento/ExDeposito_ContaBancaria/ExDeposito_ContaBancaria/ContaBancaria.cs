using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExDeposito_ContaBancaria
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome)
        {
            Deposito(depositoInicial);
        }

        public ContaBancaria(int conta, string nome)
        {
            NumeroConta = conta;
            Nome = nome;
                
        }

        public void Deposito(double valorDep)
        {
            Saldo += valorDep;
        }

        public void Saque(double valorSaq) 
        {
            Saldo -= valorSaq + 5.00;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
