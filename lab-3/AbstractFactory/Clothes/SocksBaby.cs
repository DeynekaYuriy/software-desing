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
    public class SocksBaby : IClothes
    {
        public string Name => "Baby socks";

        public ClothesSize Size { get; }

        public SocksBaby(ClothesSize size) {
            Size = size;
        }
    }
}
