using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Facade
{
    public class Cola : OrderItem
    {
        public string Name { get; }
        public int Count { get; }
        public float Price { get; }
        public Cola(int count)
        {
            Name = "Cola";
            Price = 1.99f;
            Count = count;
        }
    }
}
