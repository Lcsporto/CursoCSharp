using System;
using System.Globalization;

namespace Ex_017;

internal class Program
{
    static void Main(string[] args)
    {
        double saldo_inicial = 0;

        Console.Write("Entre com o numero da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string nome = Console.ReadLine();

        Console.Write("haverá depósito inicial (s/n)?: ");
        string validacao = Console.ReadLine();

        if (validacao == "s" || validacao == "S") 
        {
            Console.Write("Entre o valor de deposito inicial: ");
            saldo_inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Conta_Bancaria conta = new Conta_Bancaria(numero, nome, saldo_inicial);

        Console.WriteLine("Dados da conta:");
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre um valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Depositos(deposito);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre um valor para saque: ");
        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(saque);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);
        Console.WriteLine();












    }
}
