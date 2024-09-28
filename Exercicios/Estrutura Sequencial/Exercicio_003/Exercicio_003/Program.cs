using System;
using System.Globalization;

namespace Exercicio_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio_003

            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine($"Diferença: {diferenca}");
        }
    }
}