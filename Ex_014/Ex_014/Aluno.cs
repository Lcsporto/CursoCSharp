using System.Globalization;

namespace Ex_014
{
    internal class Aluno
    {
        public string Nome;
        public double nota1, nota2, nota3;

        public double SomaNotas()
        {
            return nota1 + nota2 + nota3;
        }

        public double NotaQueFalta()
        {
            return 60 - SomaNotas() ;
        }
    }
}
