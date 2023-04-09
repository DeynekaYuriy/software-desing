﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Bridge
{
    public class PixelRender : IRender
    {
        public string Render(Shape shape)
        {
            return $"Drawing {shape.Name} as pixels";
        }
    }
}
