using lab_3.AbstractFactory.Enums;
using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.AbstractFactory.Enums.Sizes;

namespace lab_3.AbstractFactory.Clothes
{
    public class SocksMale : IClothes
    {
        public string Name => "Male socks";
        public ClothesSize Size { get; }

        public SocksMale(ClothesSize size)
        {
            Size = size;
        }
    }
}
