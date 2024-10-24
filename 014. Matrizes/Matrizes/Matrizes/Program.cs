namespace Matrizes {
    internal class Program {
        static void Main(string[] args) {
            /*
             Em progrmação "Matriz" é o nome dado a arranjos bidimencionais

            Arranjo é uma estrutura de dados:
                Homogênea (dados do mesmo tipo)
                Ordenada (elementos acessados por meio de posições)
                Alocada de uma vez só, em um bloco contíguo de memória

            Vantagens 
                Acesso imediato aos elementos pela sua posição 

            Desvantagens 
                Tamanho Fixo
                Dificuldades para se realizar inserções e deleções
             */

            double[,] mat = new double[2, 3]; //A virgula indica que estamos criando um arranjo bidimensional. Instanciamos igual a um vetor. 
            
            Console.WriteLine(mat.Length); //Mostra quantos elementos a matriz tem no total. 
            Console.WriteLine(mat.Rank); //Quanto é a primeira dimensão da matriz (quantidade de linhas)
            Console.WriteLine(mat.GetLength(0)); //mostra o tamanho da primeira dimensão (linhas: 2)
            Console.WriteLine(mat.GetLength(1)); //mostra o tamanho da segunda dimensão  (colunas: 3)
            
        }
    }
}