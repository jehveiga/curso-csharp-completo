using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Heranca_Polimorfismo_Abstract_Taxa.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double incomeBase = 20000.00;

            return (AnualIncome < incomeBase) ? (AnualIncome * 0.15) - (HealthExpenditures * 0.5) : (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }
    }
}
