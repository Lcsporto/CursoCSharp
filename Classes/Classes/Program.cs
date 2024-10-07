﻿using System.Globalization;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Para abrir uma Classe, vá em 'Solution Explorer', clica com o botão direito no nome do programa, 'Add', 'Class'. 
             A classe também é um "tipo", como o double, int, string depois de criada. 

            Área Stack - É a área que faz a alocação estática das variáveis na memória.

            ------------------------------------------------------------------------------------------

            Instanciação: Alocação Dinâmica de memória. 

            Triangulo x, y; - Declaração das variáveis do tipo da classe que foi criada: 'Triangulo'.

            x = new Triangulo(); - Instaciação do objeto Triangulo. É necessário colocar a palavra 'New' para chamar a classe e instanciar o objeto. 

             */

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Forma de chamar o atributo da classe criada. 
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;

            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}