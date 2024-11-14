using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double heigth, Color color) : base(color)
        {
            Width = width;
            Height = heigth;
        }

        public override double Area() //Aqui, por essa clase ser uma Subclasse, devemos obrigatoriamente declarar o método abstrato da área. 
        {
            return Width * Height;
        }
    }
}
