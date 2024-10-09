using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_001 {
    internal class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal() {

            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

     
    }
}
