namespace Exercicio_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio_003
            int a, b;

            Console.WriteLine("Digite dois números inteiros:");
            string[] vet = Console.ReadLine().Split(" ");

            a = int.Parse(vet[0]);
            b= int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Não São Multiplos");
            }

        }
    }
}