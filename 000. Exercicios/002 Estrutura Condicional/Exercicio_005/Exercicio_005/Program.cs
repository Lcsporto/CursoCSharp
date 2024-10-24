using System;
using System.Globalization;

namespace Exercicio_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio_005
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("CODIGO    ESPECIFICAÇÃO      PREÇO");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("  1       Cachorro Quente   R$ 4.00");
            Console.WriteLine("  2       X-Salada          R$ 4.50");
            Console.WriteLine("  3       X-Bacon           R$ 5.00");
            Console.WriteLine("  4       Torrada Simples   R$ 2.00");
            Console.WriteLine("  5       Refrigerante      R$ 1.50");
            Console.WriteLine("--------------------------------------");

            int codigo, quant;
            double preco, total;

            Console.WriteLine("Digite o Código e a quantidade:");
            string[] vet = Console.ReadLine().Split(" ");

            codigo = int.Parse(vet[0]);
            preco = double.Parse(vet[1], CultureInfo.InvariantCulture);
            total = 0.0;

            if (codigo == 1){
                total = preco * 4;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2) {
                total = preco * 4.5;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3){
                total = preco * 5;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(codigo == 4)
            {
                total = preco * 2;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                total = preco * 1.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Esse código não está cadastrado.");
            }
            
        }
    }
}