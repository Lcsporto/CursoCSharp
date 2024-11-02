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
            Console.Write("BirthDate (DD/MM/YYYY): ");
            string birthDate = Console.ReadLine();

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();
            //Pega os dados das ordens
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());//Assim que é feita a instanciação de um Enum, inserindo as informações.

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status);
            Product product = new Product();
            OrderItem orderItem = new OrderItem();

            List<Product> products = new List<Product>();
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string prod_name = Console.ReadLine();

                Console.Write("Product Price: ");
                double prod_price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                product = new Product(prod_name, prod_price);
                
                orderItem = new OrderItem(quantity, prod_price, product);
                order.AddItem(orderItem);
                Console.WriteLine();
            }

                      




        }
    }
}