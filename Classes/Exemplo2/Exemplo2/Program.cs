using System;
using System.Globalization;

namespace Exemplo2 {
    internal class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Produto " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // Criada a Função AdicionarProdutos() na classe Produto. 

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados" + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); // Criada a Função RemoverProdutos() na classe Produto. 

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados" + p);






        }
    }
}