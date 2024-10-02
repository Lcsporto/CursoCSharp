namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Representam um processamento que possui um significado.    

            Principais Vantagens: Modulariazação, delegação e reaproveitamento. 

            Dados de entrada e saída
                Funções podem receber dadaos de entradas (parâmetros ou argumentos)
                Funções podem ou não retornar uma saída
                
            Em orientação a objetos, funções em classes rebem o nome de "métodos";
                         
             */

            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            /* 
            
            Programa que será criado uma função:

              if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else {
                Console.WriteLine("Maior = " + n3);
            }
            
            */

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);


        }

        //Criando a função fora do Entry Point "static void Main(string[] args)" 
        //Os Parâmetros de entrada da função não precisa ter o mesmo nome, como: n1, n2, n3.
        //O "int" representa o tipo dessa função.

        static int Maior(int a, int b, int c) {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else { 
                m = c;
            }
            return m;
        }

        //Debug Treinado


    }
}