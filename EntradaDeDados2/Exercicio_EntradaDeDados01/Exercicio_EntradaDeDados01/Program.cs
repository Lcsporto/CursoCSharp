using System;
using System.Globalization;

namespace Exercicio_EntradaDeDados01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício Entrada de Dados

            string nome, ult_nome;
            int quartos, idade;
            double p_produto, altura;


            Console.WriteLine("Entre com seu nome Completo:");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos Quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            p_produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade, e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');

            ult_nome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(p_produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ult_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}