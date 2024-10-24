namespace Exercicio_006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 006
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }

                
            }
        }
    }
}