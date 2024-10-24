namespace Exercicio_004 {
    internal class Program {
        static void Main(string[] args) {
            /*
             ) Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha 
            idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram 
            inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em 
            2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a 
            concorrer a uma vaga para a campanha milionária.
             */

            string[] nome = new string[20];
            int[] idade = new int[20];

            for (int i = 0; i < 20; i++) {
                Console.Write($"Nome #{i + 1}: ");
                nome[i] = Console.ReadLine();
                Console.Write($"Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------");
            for(int i = 0; i < 20; i++) {

                if (idade[i] >= 18 && idade[i] <= 20) {
                    Console.WriteLine(nome[i]);
                }

            }


        }

    }
}