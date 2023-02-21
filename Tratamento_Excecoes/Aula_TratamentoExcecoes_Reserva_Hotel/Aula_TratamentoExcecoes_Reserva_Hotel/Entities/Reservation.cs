using System;
using Aula_TratamentoExcecoes_Reserva_Hotel.Entities.Exceptions;

namespace Aula_TratamentoExcecoes_Reserva_Hotel.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in");
            }
            RoomNumber = roomNumber;
            Checkin = checkIn;
            Checkout = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in");
            }

            Checkin = checkIn;
            Checkout = checkOut;

        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {Checkin.ToString("dd/MM/yyyy")}, check-out: {Checkout.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

        
    }
}
