namespace ExercicioFixacao {
    internal class Program {
        static void Main(string[] args) {

            Aluno[] aluno = new Aluno[10]; //Aqui fazemos a instanciação do Vetor de uma classe

            Console.Write("Quantos Quartos serão alugados? ");
            int num_rooms = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < num_rooms; i++) {

                Console.WriteLine($"Aluguel #{i + 1}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                aluno[room] = new Aluno(nome, email);//Aqui fazemos a instanciação do objeto de uma classe

            }

            Console.WriteLine("Quartos Ocupados:");
            for (int i = 0; i < 10; i++) {

                if (aluno[i] != null) {
                    
                    Console.WriteLine($"{i}: " + aluno[i]);
                }
    
            }



        }
    }
}