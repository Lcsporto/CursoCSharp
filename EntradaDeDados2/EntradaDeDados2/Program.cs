using System;
using System.Globalization;

namespace EntradaDeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada de Dados - Parte 2

            // Para converter o texto do Console.Readline para inteiro, deve-se colocar uma função de conversão que segue abaixo: 

            int n1 = int.Parse(Console.ReadLine()); //int.Parse
            char ch = char.Parse(Console.ReadLine()); //char.Parse
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //double.Parse - Temos que tomar cuidado com o Idioma do computador. 

            //Split

            string[] vet = Console.ReadLine().Split(' '); // nome sexo idade altura
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);  
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            

            Console.WriteLine($"Você digitou: {n1}");
            Console.WriteLine($"Você digitou: {ch}");
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}