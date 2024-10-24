namespace Exercicio_003 {
    internal class Program {
        static void Main(string[] args) {
            /*  Considere um vetor de 10 números inteiros positivos maiores que zero e um único número inteiro, também positivo 
            e maior que zero. Faça um programa para: 
                a. ler pelo teclado o vetor; 
                b. ler pelo teclado o número X; 
                c. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.*/

            int[] vet = new int[10];

            Console.WriteLine("Entre 10 números inteiros maiores que 0");
            for(int i = 0; i < 10; i++) {
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("------------------");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");

            int maior = 0 , menor = 0, igual = 0;

            for(int i = 0; i < 10; i++) {

                if (vet[i] == x) {
                    igual++;
                }
                else if (vet[i] > x) {
                    maior++;
                }
                else {
                    menor++;
                }
            }

            Console.WriteLine($"Maiores: {maior}");
            Console.WriteLine($"Menores: {menor}");
            Console.WriteLine($"Iguais: {igual}");

        }
    }
}