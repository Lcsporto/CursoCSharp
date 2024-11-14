namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bloco Try: 
                Contém o código que representa a execução normal do trecho de código que pode acarretar em uma exceção

            Bloco Catch:
                Contém o código a ser executado caso uma exceção ocorra
                Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido)
             */

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException) //Aqui colocamos o tipo mais específico possível da Exceção, para tratarmos de forma adequada.
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e) //aqui o 'e' é o apelido da exceção. 
            {
                Console.WriteLine("Format error! " + e.Message);
            }

        }
    }
}
