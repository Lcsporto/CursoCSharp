using Course.Entities;
using Course.Entities.Exceptions;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Solução Ideal
             
            Cláusula Trhow: lança a exceção/ "corta" o método

            O modelo de tratamento de exceções permite que erros sejam tratados de forma consistente e flexível, usando boas práticas. 
            
            Vantagens: 

                Lógica delegada

                Construtores podem ter exceções 

                Código mais simples. Não há aninhamento de condicionais: a qualquer momento que uma exceção for disparada, a execução é 
                interrompida e cai no Bloco Catch correspondente;

                É possível capturar inclusive outras exceções de sistema;
             
             */

            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Resertvation: " + reservation);

                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in Reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unespected error: " + e.Message);
            }

        }
    }
}