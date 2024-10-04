namespace Exercicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro entre 1 e 1000: ");
            int x = int.Parse(Console.ReadLine());

            int impar = 0;

            if(x >= 1 && x <= 1000)
            {
                for(int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Número fora do intervalo!");
            }
            
        }
    }
}