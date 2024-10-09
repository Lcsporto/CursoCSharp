
namespace Exercicio_Fixacao {
    internal class ConversorDeMoeda {

        public static double Iof = 6.0;
        public static double Conversao(double cotacao, double compra) {
            return cotacao * (compra * (1 + (Iof/100.00)));
        }
    }
}
