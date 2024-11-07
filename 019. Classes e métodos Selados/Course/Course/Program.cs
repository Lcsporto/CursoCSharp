using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             É a implementação de um método de uma superclasse na subclasse

             Para que um método comum (não abstrato) possa ser sobreposto, deve ser in cluído nele o prefixo "Virtual"

             Ao sobrescrever um método, devemos incluir nele o prefixo "override" 

             Palavra Base

                É possivel chamar a implementação da superclasse chamando a palavra Base.
                    Anotação: também usamos a palavra base em contrutores. 
             */

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc1.withdraw(10.0);
            acc2.withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}