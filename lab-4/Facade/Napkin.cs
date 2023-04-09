using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Facade
{
    public class Napkin : OrderItem
    {
        public string Name { get; }
        public float Price { get; }
        public int Count { get; }
        public Napkin(int count)
        {
            Name = "Napkin";
            Price = 0f;
            Count = count;
        }
    }
}
