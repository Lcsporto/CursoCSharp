using System;
using System.Globalization;

namespace Exercicio_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio_004

            int num_fun, num_horas;
            double salario, cal_salario, val_hora;

            num_fun = int.Parse(Console.ReadLine());
            num_horas = int.Parse(Console.ReadLine());
            val_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = num_horas * val_hora;

            Console.WriteLine($"Number = {num_fun}");
            Console.WriteLine("Salary = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}