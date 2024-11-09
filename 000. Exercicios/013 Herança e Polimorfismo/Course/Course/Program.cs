using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i): ");
                char cui = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String name = Console.ReadLine();

                Console.Write("Price: ");
                Double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (cui == 'i' || cui == 'I')
                {
                    Console.Write("Customs fee: ");
                    Double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (cui == 'u' || cui == 'U')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    product.Add(new Product(name, price));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prd in product)
            {
                Console.WriteLine(prd.PriceTag());
            }

        }
    }
}