using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Bridge
{
    abstract public class Shape
    {
        private IRender _renderer;
        abstract public string Name { get; }
        public Shape(IRender renderer)
        {
            _renderer = renderer;
        }
        public string Render()
        {
            return _renderer.Render(this);
        }
    }
}
