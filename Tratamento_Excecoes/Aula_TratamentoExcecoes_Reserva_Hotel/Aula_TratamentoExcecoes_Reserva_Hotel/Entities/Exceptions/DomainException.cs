using System;

namespace Aula_TratamentoExcecoes_Reserva_Hotel.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
