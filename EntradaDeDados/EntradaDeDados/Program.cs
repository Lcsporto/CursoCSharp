namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //O Console.Readline lê a informação e sempre armazena ela como uma 'string'.
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            /* Se quisermos armazenar uma inforação do tipo 'batata tomate abacaxi' em três variáveis diferentes, porém com uma
             só digitação, precisamos usar o 'Split' - Função que serve para recortar o string em vários pedaços.*/

            string s = Console.ReadLine(); // Digite 'batata tomate abacaxi'
            string[] vet = s.Split(' '); // Esse é o comando que deve ser utilizado. Ele forma um vetor para cada espaço que tiver na digitação. 

            //string[] vet = Console.ReadLine().Split(' '); - Essa forma é uma maneira mais fácil para não criar a variável s. 

            string a = vet[0];
            string b = vet[1]; 
            string c = vet[2];

            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}