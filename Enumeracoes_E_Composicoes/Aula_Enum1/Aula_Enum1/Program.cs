using Aula_Enum1.Entities;
using System;
using Aula_Enum1.Entities.Enums;
namespace Aula_Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //convertendo para string
            string txt = OrderStatus.PendingPayment.ToString();

            //convertendo para enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
    }
}
