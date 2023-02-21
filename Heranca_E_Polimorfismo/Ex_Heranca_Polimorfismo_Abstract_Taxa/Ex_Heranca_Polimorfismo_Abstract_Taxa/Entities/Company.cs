using System;


namespace Ex_Heranca_Polimorfismo_Abstract_Taxa.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            int employeeBase = 10;

            return (NumberOfEmployees < employeeBase) ? AnualIncome * 0.16 : AnualIncome * 0.14;
        }
    }
}
