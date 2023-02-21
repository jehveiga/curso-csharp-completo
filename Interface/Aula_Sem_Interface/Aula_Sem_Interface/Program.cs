using Aula_Sem_Interface.Entities;
using Aula_Sem_Interface.Services;
using System;
using System.Globalization;

//  NO NOME DO PROJETO ESTÁ  COMO SEM INTERFACE MAS FOI IMPLEMENTADO A INTERFACE DEPOIS

namespace Aula_Sem_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price por hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price por day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model))
            {

            };

            RentalService rentalService = new RentalService(hour, day, new BrasilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
