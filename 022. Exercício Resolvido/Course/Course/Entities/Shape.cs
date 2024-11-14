using Course.Entities.Enums;

namespace Course.Entities
{
    internal abstract class Shape // Aqui com o 'abstract' deixamos a classe inteira abstrata.
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // Aqui implementamos um método abstrato, mas para isso, a classe também deve ser Abstrata. 
        
    }
}
