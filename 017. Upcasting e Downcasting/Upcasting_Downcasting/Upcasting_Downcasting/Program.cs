using Upcasting_Downcasting.Entities;

namespace Upcasting_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    Casting: Converter objeto de um tipo para outro. 

                Upcasting
                    Casting da subclasse para a superclasse 
                    Uso comum: polimorfismo

                Downcasting
                    Casting da Superclasse para a subclasse
                    Palavra as
                    Palavra is 
                    Uso comum: métodos que recebem parâmetros genéricos       
             */

            Account acc = new Account(1001, "Alex", 0.0);
            BussinessAcount bacc = new BussinessAcount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc1 = bacc; //Como o BussinessAcount É um Account, o C# aceita perfeitamente. 
            Account acc2 = new BussinessAcount(1003, "Bob", 0.0, 200.00); // A instanciação é aceita para um avariável do tipo da superclasse
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);// Isso é um UpCasting

            //DOWNCASTING

            BussinessAcount acc4 = (BussinessAcount)acc2; //Dessa forma que se faz um casting
            acc4.Loan(100.0);

            //BussinessAcount acc5 = (BussinessAcount)acc3; - Acontece um erro, pois o acc3 foi instanciado como SavingsAccount
            if (acc3 is BussinessAcount)// Assim que fazemos testes para verificar o tipo da variável
            {
                //BussinessAcount acc5 = (BussinessAcount)acc3;
                BussinessAcount acc5 = acc3 as BussinessAcount; // Forma alternativa de fazer o casting. 
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            
            

        }
    }
}