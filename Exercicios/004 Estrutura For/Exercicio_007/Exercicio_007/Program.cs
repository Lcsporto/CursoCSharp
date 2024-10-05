namespace Exercicio_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ecericio 007

            int n = int.Parse(Console.ReadLine());

            for (double i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2.0)} {Math.Pow(i, 3.0)}");
            }
        }
    }
}