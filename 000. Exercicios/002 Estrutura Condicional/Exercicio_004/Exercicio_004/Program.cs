namespace Exercicio_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio_004
            int a, b;
            int dif = 0;

            Console.WriteLine("Digite a hora inicial e hora final do jogo:");
            string[] vet = Console.ReadLine().Split(" ");

            a = int.Parse(vet[0]);
            b= int.Parse(vet[1]);
            
            if (a > b)
            {
                dif = (24 - a + b);
                Console.WriteLine($"O jogo durou {dif} Hora(s)" );
            }
            else if ( a < b)
            {
                dif = b - a;
                Console.WriteLine($"O jogo durou {dif} Hora(s)");
            }
            else
            {
                Console.WriteLine("O jogo durou 24 Hora(s)");
            }
            
            

        }
    }
}