using System;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Ex_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");

            string[] vet = Console.ReadLine().Split(' ');

            string ultimo_nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);

            Console.WriteLine(ultimo_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

           

        }
    }
}
