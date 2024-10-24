using System;
using System.Globalization;
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Lucas";
            string cargo = "Estagiário";
            string empresa = "Harald";
            char genero = 'M';


            double salário = 2270;
            double altura = 1.86;
            byte idade = 22;

            Console.WriteLine($"O meu nome é {nome}, sou do sexo {genero}. Trabalho na {empresa} e exerço o cargo de {cargo}." +
                $" Salário de {salário:F2}.");
            Console.WriteLine($"Tenho {idade} anos e " + altura.ToString("F2", CultureInfo.InvariantCulture));
            

            
        }
    }