using System;
using System.Globalization;

namespace Exercicios_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(" ");
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse((vet[1]), CultureInfo.InvariantCulture);

                if (b != 0)
                {
                    double div = a / b;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Divisão Impossível");
                }


            }
        }
    }
}