using Course.Services;

namespace Course
{
    delegate double BinaryNumericOperation(double n1, double n2); // declaração do Delegate
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             DELEGATES

             É uma referência (com type Safety) para um ou mais métodos 
                É um tipo referência

            Usos Comuns: 
                Comunicação entre objetos de forma flexível e extensível (eventos / callbacks)
                Parametrização de operações por métodos (programação funcional)

            Delegates Pré Definidos:
                
                Action
                Func
                Predicate
             */

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);

            double result = op(a, b);
            //double result = op.Invoke(a, b);
            Console.WriteLine(result);

        }
    }
}
