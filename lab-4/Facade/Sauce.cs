using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Facade
{
    public class Sauce : OrderItem
    {
        public string Name { get; }

        public float Price { get; }

        public int Count { get; }
        public Sauce(int count)
        {
            Name = "Sauce";
            Price = 0.99f;
            Count = count;
        }
    }
}
