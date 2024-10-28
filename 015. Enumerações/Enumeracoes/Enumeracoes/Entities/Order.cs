using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes.Entities // Por padrão, o C# atribui o nome como: Projeto.Pasta
{
    internal class Order
    {

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id 
                + ", " 
                + Moment 
                + ", " 
                + Status;
        }

    }
}
