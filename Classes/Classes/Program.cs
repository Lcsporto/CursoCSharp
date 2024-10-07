using System.Globalization;

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

            ------------------------------------------------------------------------------------------
            Criando método para benefícios de reaproveitamento e Delegação

            O método é uma função dentro da Classe

            Criado a função 'Area'

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


            double areaX = x.Area();
            double areaY = y.Area();

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