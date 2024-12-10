using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Predicate

                Representa um método que recebe um objeto do tipo T e retorna um vlaor Booleano

                public delegate bool Predicate< in T >(T obj);
             */

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(p => p.Price >= 100.0); // O que vem dentro como argumento é uma expressão Lambda
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
