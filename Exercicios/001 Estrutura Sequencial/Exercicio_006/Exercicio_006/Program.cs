using System;
using System.Globalization;

namespace Exercicio_006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio_006

            double a, b, c, a_triangulo, a_circulo, a_trapezio, a_quadrado, a_retangulo;
            double pi = 3.14159;

            string[] vet = Console.ReadLine().Split(" ");

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Area do trinagulo retângulo:
            a_triangulo = (a * c) / 2;

            //Area do circulo:
            a_circulo = pi * Math.Pow(c, 2F);

            //Area do trapézio:
            a_trapezio = ((a + b) * c) / 2;

            //Area do quadrado:
            a_quadrado = Math.Pow(b, 2F);

            //Area do retangulo:
            a_retangulo = a * b;

            Console.WriteLine("Triangulo: " + a_triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + a_circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + a_trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + a_quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + a_retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}