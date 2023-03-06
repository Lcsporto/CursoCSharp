using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Ex_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}