using System;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Ex_001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou {n1}");

            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
