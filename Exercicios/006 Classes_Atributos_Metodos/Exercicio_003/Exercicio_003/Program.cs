using System;
using System.Globalization;

namespace Exercicio_003 {
    internal class Program {
        static void Main(string[] args) {

            //Exercicio 003 - A Forma que eu fiz chega no Resultado, porém, a forma da correção do Professor isola os cálculos apenas a área da classe. 
            
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno);

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}