namespace Exercicio_002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma_in = 0;
            int soma_out = 0;
            int x = 0;

            Console.Write("Quantos números serão digitados? ");
            int n = int.Parse(Console.ReadLine());
                    
            
            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    soma_in++;
                }
                else
                {
                    soma_out++;
                }
            }

            Console.WriteLine($"{soma_in} in");
            Console.WriteLine($"{soma_out} out");

        }
    }
}