using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                HashSet<T> e Sortedset<T>

                Representa um conjunto de elementos (similar ao da Álgebra)
                    Não admite repetições
                    Elementos não possuem posição
                    Acesso, inserção e remoção de elementos são rápidos
                    Oferece operações eficientes de conjunto: inserção, união, diferença.

                Diferenças 

                HashSet
                    Armazenamento em tabela hash
                    Extremamente rápido: inserção, remoção e busca O(1) - apenas um passo para chegar no dado. 
                    A ordem dos elementos não é garantida

                SortedSet
                    Armazenamento em árvore
                    Rápido: inserção, remoção e busca O(log(n)) - Base logarítmica.
                    Os elementos são armazenados ordenadamente conforme implementação IComparer<T>

                Métodos Importantes: 

                    Add
                    Clear
                    Contains
                    UnionWith(other) - operação união: adiciona no conjunto os elementos do outro conjunto, sem repetição;
                    IntersectWith(other) - operação de Interseção: remove do conjunto os elementos não contidos em other;
                    ExceptWith(other) - Operação de diferença: remove do conjunto os elementos contidos em other;
                    Remove(T)
                    RemoveWhere(predicate)
             */

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); //retorna True ou False

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

        }
    }
}
