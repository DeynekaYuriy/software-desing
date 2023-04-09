using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Bridge
{
    public class Circle : Shape
    {
        public override string Name => "Circle";

        public Circle(IRender renderer) : base(renderer)
        {
        }

    }
}
