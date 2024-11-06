using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*É um tipo de associação que permite que uma classe herde dados e comportamentos de outra. 
            Vantagens: Reuso e Polimorfismo

            Sintaxe
                :(extende)
                base(referência para a superclasse)

            A Herança permite o Reuso de atributos e métodos (dados e comportamentos)

            Definições importantes: 
                Relação "é-um"
                Generalização/Especialização
                Superclasse (classe base) / Subclasse (classe derivada)
                Herança / Extensão
                Herança é uma associação entre classes (e não entre objetos)

             */

            BussinessAcount account = new BussinessAcount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance );

        }
    }
}