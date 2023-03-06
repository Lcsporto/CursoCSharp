using System;
using System.Globalization;

namespace Ex_009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combustivel = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (combustivel != 4) {
                combustivel = int.Parse(Console.ReadLine());

                if (combustivel == 1)
                {
                    alcool += 1;
                }
                else if (combustivel == 2) {
                    gasolina += 1;
                }
                else if(combustivel == 3) { 
                    diesel += 1;
                }
            }

            Console.WriteLine("MUITO OBRIGADO \nAlcool:" + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            
        }
    }
}