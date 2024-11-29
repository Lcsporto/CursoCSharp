using System;
using Course;

namespace Course
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

            PrintService printservice = new PrintService();

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
