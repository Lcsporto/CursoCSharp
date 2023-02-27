using System;
using System.Linq.Expressions;

namespace Ex_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fim;
            int duracao;

            Console.WriteLine("Digite a hora de inicio do jogo:");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora do fim do jogo");
            fim = int.Parse(Console.ReadLine());

            if (inicio == fim)
            {
                duracao = 24;
            }
            else if(fim < inicio)
            {
                duracao = (24 - inicio) + fim;
            }
            else
            {
                duracao = fim - inicio;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

        }
    }
}
