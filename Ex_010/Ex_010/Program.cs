using System;
using System.Threading.Tasks.Dataflow;

namespace Ex_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.Write("Nome da Primeira pessoa: ");
            a.Nome = (Console.ReadLine());
            Console.Write("Idade da Primeira pessoa: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.Write("Nome da Segunda pessoa: ");
            b.Nome = Console.ReadLine();
            Console.Write("Iadade da segunda pessoa: ");
            b.Idade = int. Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha :" + b.Nome);
            }

        }
    }
}