using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Facade
{
    public class Packaging : OrderItem
    {
        public string Name { get; }
        public float Price { get; }
        public int Count { get; }
        public Packaging(int count)
        {
            Name = "Takout packaging";
            Price = 0.49f;
            Count = count;
        }
    }
}
