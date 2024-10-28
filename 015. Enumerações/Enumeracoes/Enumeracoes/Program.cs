using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Enumeração

            É um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas;

            Palavras passe em c#: enum
                Nota: enum é um tipo valor;

            Vantagem: melhor semântica, código mais legível e auxilixado pelo compilador.
               
             */

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}