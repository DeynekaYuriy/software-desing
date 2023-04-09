using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Facade
{
    public class Fries : OrderItem
    {
        public string Name { get; }
        public float Price { get; }
        public int Count { get; }
        public Fries(int count)
        {
            Name = "Fries";
            Price = 1.99f;
            Count = count;
        }
    }
}
