using Course.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Course.Entities {
    class Order {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();

        public Order() {}

        public Order(OrderStatus status, Client client) {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            OrderItems.Remove(item);
        }

        public double Total() {
            double total = 0d;
            foreach (OrderItem item in OrderItems)
                total += item.SubTotal();
            return total;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItems)
                sb.AppendLine(item.ToString());
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}