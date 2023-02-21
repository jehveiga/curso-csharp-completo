using Ex_Pedidos_Itens.Entities.Enums;
using System;
using Ex_Pedidos_Itens.Entities;
using System.Globalization;

namespace Ex_Pedidos_Itens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameProd, price);

                Console.Write("Quantity: ");
                int quantidade = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantidade, price, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
