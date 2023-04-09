using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Bridge
{
    public class Triangle : Shape
    {
        public override string Name => "Triangle";
    
        public Triangle(IRender renderer) : base(renderer)
        {
        }

    }
}
