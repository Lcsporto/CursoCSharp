namespace Exercicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            int valor;

            Console.Write("Digite a Senha: ");
            valor = int.Parse(Console.ReadLine());

            while (valor != senha)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite outra senha: ");
                valor= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}