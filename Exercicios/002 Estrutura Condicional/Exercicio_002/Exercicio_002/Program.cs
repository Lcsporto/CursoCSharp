namespace Exercicio_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio_002
            int num;
            Console.WriteLine("Digite um número inteiro:");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Impar");
            }
        }
    }
}