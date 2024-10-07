using System;

namespace Classes
{
    internal class Triangulo
    {

        public double A; //public significa que esses atributos poderão ser acessados por outro arquivo. Ex: O programa Principal 'Program.cs'.
        public double B;
        public double C;

        public double Area() // Criando uma função que faz o cálculo da área do triangulo. 
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }


    }
}
