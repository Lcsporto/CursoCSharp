using System;
using System.Globalization;

namespace Exercicio_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício_002
            double pi, raio, area; 
            pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(raio, 2F);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}