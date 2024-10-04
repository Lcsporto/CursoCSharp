namespace Exercicio_003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Sair");
            Console.WriteLine("-----------------------");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("Digite a opção desejada: ");
            int cont = int.Parse(Console.ReadLine());

            while (cont != 4)
            {
                if (cont == 1)
                {
                    alcool += 1;
                }
                else if (cont == 2) {
                    gasolina += 1;
                }
                else if (cont == 3) {
                    diesel += 1;
                }
                Console.Write("Digite a opção desejada: ");
                cont = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);




        }
    }
}