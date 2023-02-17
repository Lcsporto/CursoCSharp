using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            
            Console.WriteLine("Produtos: \n\n{0}, cujo preço é $ {1}\n{2}, cujo preço é $ {3}", produto1, preco1, produto2, preco2);
            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"\nMedida com oito casa decimais: {medida}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}