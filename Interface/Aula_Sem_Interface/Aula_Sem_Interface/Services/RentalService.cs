using Aula_Sem_Interface.Entities;
using System;

namespace Aula_Sem_Interface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        public ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); // metodo para retornar um intervalo de tempo entre uma data/hour inicial por outra final

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // retorna o valor de um total de hours arredondando para cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays); // retorna o valor de um total de dias arredondando para cima
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
