using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_TratamentoExcecoes_ContaBancaria.Entities.Exceptions;

namespace Ex_TratamentoExcecoes_ContaBancaria.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount )
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance && amount < WithdrawLimit)
            {
                throw new DomainException("Not enough balance");
            }
            if(amount > WithdrawLimit || amount > Balance)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }

    }
}
