namespace Exercicio_005 {
    internal class Program {
        static void Main(string[] args) {

            /*
                 Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes 
                 que V1 e V2 possuem valores idênticos nas mesmas posições.
             */

            int[] V1 = new int[5];
            int[] V2 = new int[5];

            Console.WriteLine("Insira os valores de V1: ");
            for(int i = 0; i < 5; i++) {
                V1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insira os valores de V2: ");
            for (int i = 0; i < 5; i++) {
                V2[i] = int.Parse(Console.ReadLine());
            }

            int val_iguais = 0;

            for (int i = 0; i < 5; i++) {

                if (V1[i] == V2[i]) {
                    val_iguais++;
                }
            }

            Console.WriteLine($"Há {val_iguais} valores identicos na mesma posição entre V1 e V2");

        }
    }
}