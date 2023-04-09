using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Facade
{
    public class BigMacBurger : OrderItem
    {
        public string Name { get; }
        public float Price { get; }
        public int Count { get; }
        public BigMacBurger(int count)
        {
            Name = "Big Mac Burger";
            Price = 2.99f;
            Count = count;
        }
    }
}
