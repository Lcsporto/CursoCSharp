using System;
using System.Data;

namespace Ex_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine()); 

            if (a % b ==0 || b % a == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }
        }
    }
}
