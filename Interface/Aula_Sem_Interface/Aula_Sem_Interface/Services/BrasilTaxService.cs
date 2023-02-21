namespace Aula_Sem_Interface.Services
{
    class BrasilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            return amount <= 100 ? amount * 0.2 : amount * 0.15;
        }
    }
}
