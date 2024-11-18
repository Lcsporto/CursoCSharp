using Course.Entities;
using Course.Exceptions;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");

                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double inicialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, inicialBalance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount of withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(withdraw);

                Console.WriteLine(account);
            }
            catch (AccountException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unspected error: " + e.Message);
            }


        }
    }
}
