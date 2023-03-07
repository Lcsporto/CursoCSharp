using System;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;

namespace Ex_015
{
    internal class Program   
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.Conversor(cot, dol).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}