using System;
using System.Globalization;
namespace Ex_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            float A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de B:");
            float B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de C:");
            float C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float pi = 3.14159F;

            float area_triangulo = (A * C) / 2;
            float area_circulo = pi * (C * C);
            float area_trapezio = ((A + B) * C) / 2;
            float area_quadrado = B * B;
            float area_retangulo = A * B;

            Console.WriteLine("TRIÂNGULO: " + area_triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + area_circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + area_trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + area_quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + area_retangulo.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
