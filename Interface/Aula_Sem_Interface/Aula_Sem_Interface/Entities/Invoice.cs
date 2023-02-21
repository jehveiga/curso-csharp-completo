using System.Globalization;

namespace Aula_Sem_Interface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        // Propriedade que retorna o calculo do pagamento total do aluguel do veiculo
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTotal payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
