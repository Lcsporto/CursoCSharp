using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Ex_015
{

    internal class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double Conversor(double cotacao, double DolCompra)
        {
            return (DolCompra * cotacao) + (DolCompra * Iof * cotacao);
            
        }

    }
}
