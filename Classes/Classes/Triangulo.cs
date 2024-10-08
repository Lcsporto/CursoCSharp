using System;

namespace Classes
{
    internal class Triangulo
    {

        public double A; //public significa que esses atributos poderão ser acessados por outro arquivo. Ex: O programa Principal 'Program.cs'.
        public double B;
        public double C;

        // Criando uma função que faz o cálculo da área do triangulo.
        public double Area() //Aqui não foi necessário colocar nenhum parâmtro de entrada pois todas as variáveis já se encontram na classe. 
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }


    }
}
