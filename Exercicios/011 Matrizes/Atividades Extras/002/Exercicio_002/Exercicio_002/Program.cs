using System.Net;

namespace Exercicio_002 {
    internal class Program {
        static void Main(string[] args) {
            /* Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores.Ou seja, realizar
            a soma de todos dos resultados da multiplicação de x[i] por y[i]. */

            Console.Write("Entre a quantidade de elementos: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");

            int[] x = new int[n];
            int[] y= new int[n];

            Console.WriteLine("Entre com os valores de x: ");
            for (int i= 0; i < n; i++) {
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------");

            Console.WriteLine("Entre com os valores de y: ");
            for (int i = 0; i < n; i++) {
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------");

            int soma = 0;
            for (int i =0; i < n; i++) {
                int mult = x[i] * y[i];
                soma += mult;
            }
            Console.WriteLine("---------------------");
            Console.WriteLine($"Soma = {soma}");
        }
    }
}