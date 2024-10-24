using Course;

namespace AutoProperties {
    internal class Program {
        static void Main(string[] args) {
            /*
             Propriedades Autoimplementadas

             É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para operações get e set.
             */

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
           
        }
    }
}