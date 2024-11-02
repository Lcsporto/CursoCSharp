using Course.Entities.Enums;
using System.Data.Common;
using System.Text;
using System.Globalization;

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Order Moment: {Moment}");
            sb.AppendLine($"Order Status: {Status}");
            
            foreach(OrderItem oi in OrderItens)
            {
                sb.Append(oi.Product.Name);
                sb.Append(", $" + oi.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: " + oi.Quantity);
                sb.AppendLine(", Subtotal: $" + oi.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }

            sb.Append("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
