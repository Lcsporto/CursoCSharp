using System;
using System.Globalization;

namespace Exemplo2 {
    internal class Program {
        static void Main(string[] args) {

            //Construtor é uma operação especial da classe, que executa no momento da instanciação do objeto.
            //Com o construtor declarado, o progrmador é obrigado a inserir os argumentos na instanciação do objeto.
            //Produto p = new Produto("TV", 500.0, 10);

            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());*/

            Produto p = new Produto(nome, preco); // Com o construtor declarado, o objeto é instanciado depois.

            Console.WriteLine();
            Console.WriteLine("Produto " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}