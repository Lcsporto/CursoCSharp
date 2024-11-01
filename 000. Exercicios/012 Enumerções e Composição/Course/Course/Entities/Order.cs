using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = DateTime.Now;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }

        public double Total() {
            double total = 0;

            foreach (OrderItem item in OrderItens) {
                 total += item.SubTotal();           
            }
            return total;
        }
    }
}
