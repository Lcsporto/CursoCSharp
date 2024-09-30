using System;
using System.Globalization;

namespace Exercicio_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double renda;
            double imp_renda = 0.00;
            

            Console.WriteLine("Qual sua renda (R$) ?");
            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (renda > 0 && renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if( renda <= 3000.00)
            {
                imp_renda = (renda - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imp_renda.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if ( renda <= 4500.00)
            {
                imp_renda = ((renda - 3000.00) * 0.18) + 80.00; // Os 80.00 corresponde a parte dos 8% nos 1000.00
                Console.WriteLine("R$ " + imp_renda.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imp_renda = ((renda - 4500.00) * 0.28) + 350.00; // O 350.00 Corresponde a 80 dos 8% e 270.00 dos 18%
                Console.WriteLine("R$ " + imp_renda.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}