using System;
using Course2;

namespace Course2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Generics permitem que classes, interfaces e métodos possam ser parametrizados por tipo. Seus benefícios são:
                    Reuso
                    Type Safety
                    Performance

                Uso comum: Coleções
             */

            PrintService<int> printservice = new PrintService<int>(); // Aqui colocamos entre <> o tipo que queremos instanciar o nosso objeto. 

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printservice.AddValue(x);
            }

            printservice.Print();
            Console.WriteLine("First: " + printservice.First());
        }
    }
}
