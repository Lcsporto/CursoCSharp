namespace Exercicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio_001
            int num;

            Console.WriteLine("Digite um número inteiro:");
            num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Não Negativo!");
            }
            else
            {
                Console.WriteLine("Negativo!");
            }
        }
    }
}