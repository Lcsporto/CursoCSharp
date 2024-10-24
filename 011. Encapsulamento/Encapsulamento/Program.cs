using Course;

namespace Encapsulamento {
    internal class Program {
        static void Main(string[] args) {

            // É um principio que consiste em esconder detalhes de implementação de um componente, expondo apenas operações seguras e que o mantenha em um estado consistente.

            // Regra de Ouro: o objetivo deve sempre estar em um estado consistente, e a própria classe deve garantir isso.

            /*
                Opção 1: Implementação Manual
            
                Todo Atributo é definido como private
                Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio.
                Nota: não é usual na plataforma C#
             */

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K"); // É utilizado a função para poder modificar o atributo nome da classe 'Produto'.

            Console.WriteLine(p.GetNome()); //Usando a função para acessar o atributo Nome do produto. 
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade);

        }
    }
}