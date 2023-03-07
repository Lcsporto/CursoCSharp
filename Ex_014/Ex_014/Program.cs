using System;
using System.Globalization;

namespace Ex_014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aln = new Aluno();

            Console.Write("nome do aluno:");
            aln.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aln.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aln.SomaNotas().ToString("F2", CultureInfo.InvariantCulture));
            if (aln.SomaNotas() > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aln.NotaQueFalta().ToString("F2", CultureInfo.InvariantCulture) + "PONTOS");
            }

            
        }
    }
}