using System.Globalization;

namespace Exemplo2 {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        //Aqui é onde fazemos a declaração do construtor. Geralmente depois dos atributos.
        public Produto() {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() { //O 'this' serve para chamar o Produto() e utilizar os atributos dele. 
            this.Nome = nome; //o 'this' serve para indicar a varável local do atributo do objeto. E não o parâmetro da função.
            this.Preco = preco;
           // Quantidade = 5; // Não é preciso deeclarar, pois na instanciação ele já viria 0. Mas é possível iniciar o atributo com outro valor.
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            this.Quantidade = quantidade;
        }

        

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
