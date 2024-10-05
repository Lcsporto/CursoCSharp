using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Exercicio_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(" ");
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            

            
        }
    }
}