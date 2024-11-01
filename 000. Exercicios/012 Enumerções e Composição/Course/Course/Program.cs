using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pega os dados do Cliente
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("BirthDate (DD/MM/YYYY) ");
            string birthDate = Console.ReadLine();

            Console.WriteLine();
            //Pega os dados das ordens
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());//Assim que é feita a instanciação de um Enum, inserindo as informações.

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.WriteLine("Product name: ");
                string prod_name = Console.ReadLine();

                Console.WriteLine("Product Price: ");
                double prod_price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(prod_name, prod_price);
                // Faça a instanciação da ordem antes do laço For. (Pensamento)

            }

            




        }
    }
}