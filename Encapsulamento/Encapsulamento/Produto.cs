using System.Globalization;
namespace Course {
    class Produto {
        private string _nome;// Por coonvenção, quando utiliza o atributo com private, inicia-se o nome com '_' e letra minúscula.
        private double _preco;
        private int _quantidade; // o Private significa que o atributo é privativo: Não pode ser acessado por outra classe.

        public Produto() { }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Com os atributos como 'private' é importante criar uma funcão "public" para poder ter acessos aos atributos.
        public string GetNome() {
            return _nome;
        }

        //Aqui é criado uma função para poder modificar o atributo. Como ele não possui nenhum retorno, ele é um 'void'.
        public void SetNome( string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }

        public double ValorTotalEmEstoque() {
            return _preco *= _quantidade;
        }
        
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}