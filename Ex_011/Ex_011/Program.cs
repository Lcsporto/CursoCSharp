using System;
using System.Globalization;

namespace Ex_011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.Write("Nome do primeiro funcionário: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salario do primiero funcionario: ", CultureInfo.InvariantCulture);
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nome do segundo funcionário: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salario do segundo funcionario: ", CultureInfo.InvariantCulture);
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario_medio = (func1.Salario + func2.Salario) / 2;
            Console.Write("Salário Médio: " + salario_medio, CultureInfo.InvariantCulture);


        }
    }
}
