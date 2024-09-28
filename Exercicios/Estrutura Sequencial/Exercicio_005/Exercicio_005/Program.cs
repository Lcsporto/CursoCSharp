using System;
using System.Globalization;

namespace Exercicio_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício_005

            int p1, num_p1, p2, num_p2;
            double val_p1, val_p2, total;

            string[] vet1 = Console.ReadLine().Split(" ");
            string[] vet2 = Console.ReadLine().Split(" ");

            p1 = int.Parse(vet1[0]);
            num_p1= int.Parse(vet1[1]);
            val_p1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            p2 = int.Parse(vet2[0]);
            num_p2 = int.Parse(vet2[1]);
            val_p2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            total = (num_p1 * val_p1) + (num_p2 * val_p2);
            Console.WriteLine("Valor a Pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}