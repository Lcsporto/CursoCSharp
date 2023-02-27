using System;

namespace Ex_005 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double codigo;
            double quantidade;
            double totalaPagar;

            Console.WriteLine("Digite o código do produto:");
            codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos:");
            quantidade= double.Parse(Console.ReadLine());

            if (quantidade >= 1) { 
                if(codigo == 1)
                {
                    totalaPagar = 4 * quantidade;
                    Console.WriteLine($"Total: R${totalaPagar}");
                }
                else if(codigo == 2)
                {
                    totalaPagar = 4.5 * quantidade;
                    Console.WriteLine($"Total: R${totalaPagar}");
                }
                else if (codigo == 3)
                {
                    totalaPagar = 5 * quantidade;
                    Console.WriteLine($"Total: R${totalaPagar}");
                }
                else if (codigo == 4)
                {
                    totalaPagar = 2 * quantidade;
                    Console.WriteLine($"Total: R${totalaPagar}");
                }
                else if (codigo == 5)
                {
                    totalaPagar = 1.50 * quantidade;
                    Console.WriteLine($"Total: R${totalaPagar}");
                }
                else
                {
                    Console.WriteLine("O código do produto é inexistente");
                }
                
            }
            else
            {
                Console.WriteLine("A quantidade não existe!");
            }      


        }
    }
}
