namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             GetHashCode e Equals

                São operações da classe Object utilizados para comparar se um objeto é igual a outro. 

                Equals: lento, resposta 100%
                GetHashCode: rápido, porém resposta positiva não é 100%

                Os tipos pré definidos já possuem implementação para essas operações. Classes e Structs personalisados precisam sobrepo-las. 
             */

            //Equals - Método que compara se o objeto é igual ao outro, retornando true ou false. 

            string a = "Maria";
            string b = "Maria";
            string c = "João";
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(c));

            Console.WriteLine();

            //GetHashCode - Método que retorna um número inteiro representando um código gerado a partir das informações do objeto. 

            string d = "Maria";
            string e = "Maria";
            string f = "Alex";

            Console.WriteLine(d.GetHashCode());
            Console.WriteLine(e.GetHashCode());
            Console.WriteLine(f.GetHashCode());

            /*
             Regra de Ouro do GetHashCode

                Se o código de dois objetos for diferente, então os dois objetos são diferentes;

                Se o código de dois objetos for igual, muito provavelmente os objetos são iguais (pode haver colisão);
             */


        }
    }
}
