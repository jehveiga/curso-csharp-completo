using System;
using System.Collections.Generic;
using System.Globalization;
using Ex_Fixacao_Produtos.Entities;

namespace Ex_Fixacao_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> product = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n;i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(op == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(name, price, customs));
                }else if(op == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY) ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufacture));
                }
                else
                {
                    product.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product prod in product) 
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
