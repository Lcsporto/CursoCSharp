using System.Globalization;

namespace Vetores {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; // Declaração de um Vetor

            //Forma de inserir informações em um Vetor
            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Fazendo a soma das informações inseridas nos Vetores. 
            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVARAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}