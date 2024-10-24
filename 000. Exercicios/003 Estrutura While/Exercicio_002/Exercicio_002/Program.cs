using System;
using System.Globalization;

namespace Exercicio_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Digite duas Coordenadas do plano Cartesiano: ");
            string[] vet = Console.ReadLine().Split(" ");

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != 0 && y != 0) // O correto nessa linha não seria ser um OU outro ? X OU Y = 0 ? (||) ?
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                Console.Write("Digite outras Coordenadas do plano Cartesiano: ");
                string[] vet1 = Console.ReadLine().Split(" ");

                x = int.Parse(vet1[0]);
                y = int.Parse(vet1[1]);
            }
        }
    }
}