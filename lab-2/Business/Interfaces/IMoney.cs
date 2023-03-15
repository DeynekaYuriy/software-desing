using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    //Interface Segregation Principle, A client should never be forced to implement an interface that it doesn't use
    public interface IMoney
    {
        public void Add(float amount);
        public void Subtract(float amount);
        public float GetAmount();
        public void SetAmount(float amount);
    }
}
