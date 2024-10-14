using System.Globalization;

namespace ExercicioFixacao {
    internal class Program {
        static void Main(string[] args) {
            
            Console.Write("Entre o número da Conta: ");
            int NumConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string NomeTit = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char VerDepInicial = char.Parse(Console.ReadLine());

            double DepInicial = 0.0;
            if (VerDepInicial == 's') {
                Console.Write("Entre o valor de depósito incial: ");
                DepInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta c = new Conta(NumConta, NomeTit, DepInicial);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);


            

        }
    }
}