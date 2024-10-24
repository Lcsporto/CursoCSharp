using System;
using System.Globalization;

namespace Exercicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 001

            int a, b, soma;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            soma = a + b;
            Console.WriteLine($"Soma = {soma}");
        }
    }
}