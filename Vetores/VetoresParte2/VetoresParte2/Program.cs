using System.Globalization;

namespace VetoresParte2 {
    internal class Program {
        static void Main(string[] args) {
            //Vetores orinetados a classe

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            //Como estamos fazendo o vetor de uma classe, é necessário fazer a instânciação de cada objeto.
             for(int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price }; //instânciação do objeto no Price
             }

            double sum = 0.0;
            for(int i = 0; i < n; i++) { 
                sum += vect[i].Price; //É necessário pegar a "Caixinha" de preço do objeto.
            }

            double avg = sum / n;
            Console.WriteLine("AVARAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}