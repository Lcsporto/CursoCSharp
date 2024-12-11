using System.Linq;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            LINQ - Language Integrated Query
            
            É um conjunto de tecnologias baseadas na integração de funcionalidades de consulta diretamente na linguagem C#

                Operações chamadas diretamente a partir das coleções 
                Consultas são objetos de primeira classe 
                Suporte do compilador e IntelliSense da IDE

            Namespace: System.Linq

            Possui diversas operações de consulta, cujos parâmetros tipicamente são expressões lambda ou expressões 
            de sintaxe similar a SQL. 

             */

            //Specify Data Source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the Query expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Execute the Query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
