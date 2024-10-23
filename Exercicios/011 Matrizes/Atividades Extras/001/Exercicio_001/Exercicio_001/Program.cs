namespace Exercicio_001 {
    internal class Program {
        static void Main(string[] args) {
            //Vetores e Matrizes

            //Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura. 

            Console.Write("Informe a quantidade de números: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");

            int[] vet = new int[n];

            for (int i = 0; i < n; i++) {
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------------------------");
            for (int i = n; i > 0; i--) {
                Console.WriteLine(vet[i-1]);
            }


        }
    }
}