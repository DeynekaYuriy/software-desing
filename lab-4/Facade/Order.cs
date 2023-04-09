using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Facade
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public float TotalPrice => Items.Sum(x => x.Price * x.Count);
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder($"${TotalPrice} Order:\n");
            foreach (var item in Items)
            {
                builder.AppendLine($"{item.Name} - ${item.Price * item.Count}(x{item.Count})");
            }
            return builder.ToString();
        }
    }
}
