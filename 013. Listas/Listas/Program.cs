using System.Collections.Generic;

namespace Listas {
    internal class Program {
        static void Main(string[] args) {
            /* Listas 
             A Grande diferença entre lista e Vetor, é que a lista inicia vazia, e seus elementos são alocados sob demanda. 
             Uma vez que no vetor, temos que passar a quantidade de elementos, na lista não é necessário. 

            Classe: List
            Namespace: System.Collections.Generic;

            Vantagens: tamanho Variável, Facilidade para se realizar inserções e deleções. 
            Desvantagens: Acesso sequencial aos elementos. (geralmente esses acessos são otimizados). 
             
             */

            List<string> list = new List<string>(); //Instanciação de uma lista vazia;

            List<string> list2 = new List<string> {"Maria", "Alex"};// instanciação de uma lista com elementos;


        }
    }
}