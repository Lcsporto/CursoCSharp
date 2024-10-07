using System.Collections.Concurrent;

namespace Exercicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 001

            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {a.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa Mais Velha: {b.Nome}");
            }



        }
    }
}