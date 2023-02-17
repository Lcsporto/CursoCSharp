using System;
using System.Security.Cryptography.X509Certificates;

namespace Ex_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] vet = x.Split(" ");
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(x);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);


        }
    }
}
