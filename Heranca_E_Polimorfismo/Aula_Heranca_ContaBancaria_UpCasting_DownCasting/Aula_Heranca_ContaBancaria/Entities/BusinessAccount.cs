using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Heranca_ContaBancaria.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit) 
            {
                Balance += amount;
            }
            
        }
    }
}
