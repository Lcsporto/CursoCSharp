using System.Collections.Generic;

namespace Listas_Parte2 {
    internal class Program {
        static void Main(string[] args) {
            
            List<string> list = new List<string>(); // Aqui, se instancia a lista

            list.Add("Maria"); //A Função 'Add', por padrão adiciona os elementos no final da lista;
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); //O 'Insert' você consegue colocar na posição em que desejar na lista;

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count: " + list.Count);//Conta a quantidade de elementos da lista

            string s1 = list.Find(x => x[0] == 'A');// Essa é uma expressão lambda. O 'Find' encontra o primerio elemento de acordo com um lógica (predicado) descrito. 
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');// O 'FindLast' encontra o último elemento de acordo com o predicado passado. 
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');// O 'FindIndex' encontra a primeira posição de acordo com o predicado. 
            Console.WriteLine("Fisrt position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');// O 'FindLastIndex' encontra a ultima posição de acordo com o predicado. 
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);// Para filtrarmos de acordo com nosso predicado, criamos uma nova lista que abrangerá o resultado. 
            Console.WriteLine("-------------------------------");

            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");// "Remove' - Remove um objeto da lista; 'RemoveAt' - Remove uma posição da lista; 'RemoveRenage' - remove uma faixa da lista.
            Console.WriteLine("-------------------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');//Remove todos que começam com o predicado passado. 
            Console.WriteLine("-------------------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }




        }

    }
}