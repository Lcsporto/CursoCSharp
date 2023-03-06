using System;
using System.Globalization;

namespace Ex_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quadrante = " ";
            
            while (quadrante != "")
            {
                Console.Write("Digite o valor de X: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de y: ");
                int y = int.Parse(Console.ReadLine());

                quadrante = Quadrante(x, y);
                Console.WriteLine(quadrante);
            }
        }


        static string Quadrante(int a , int b)
        {
            string result;

            if (a > 0 && b > 0)
            {
                result = "primeiro";
            }
            else if (a < 0 && b > 0)
            {
                result = "segundo";
            }
            else if (a < 0 && b < 0)
            {
                result = "terceiro";
            }
            else if (a > 0 && b < 0)
            {
                result = "quarto";
            }
            else
            {
                result = "";
            }
            return result;

        }

    }
}
