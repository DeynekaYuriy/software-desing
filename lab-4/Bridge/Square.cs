using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Bridge
{
    public class Square : Shape
    {
        public override string Name => "Square";

        public Square(IRender renderer) : base(renderer)
        {
        }
    }
}
