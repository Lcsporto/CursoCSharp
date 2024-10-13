using Course;

namespace Properties {
    internal class Program {
        static void Main(string[] args) {
            /*
             Properties

             São definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e não a de métodos.

             */

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}