using Course.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Representa um método que recebe zero ou mais argumentos, e retorna um valor

            public delegate TResult Func<out TResult>();
            public delegate TResult Func<in T, out TResult>(T obj);
            public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
            public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 
            arg2, T3 arg3)

             */

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> result = list.Select(NameUpper).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

    }
}
