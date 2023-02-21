using Ex_Heranca_Polimorfismo_Abstract_Taxa.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_Heranca_Polimorfismo_Abstract_Taxa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> list = new List<TaxPayer>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)?");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(op == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double sum = 0.0;
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.ToString());
                sum += tax.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
