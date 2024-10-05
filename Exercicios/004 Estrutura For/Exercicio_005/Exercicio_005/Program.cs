namespace Exercicio_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 005
            int n = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i < n; i++) {

                if (result != 1)
                {
                    result = result * (n - i);
                }
                else
                {
                    result = n * (n - i);
                }
            
            }
            Console.WriteLine(result);

            /*
             
            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
             */

        }
    }
}