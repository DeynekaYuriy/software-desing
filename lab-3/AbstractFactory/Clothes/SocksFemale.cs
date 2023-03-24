using lab_3.AbstractFactory.Enums;
using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.AbstractFactory.Enums.Sizes;

namespace lab_3.AbstractFactory.Clothes
{
    public class SocksFemale : IClothes
    {
        public string Name => "Female socks";
        public ClothesSize Size { get; }

        public SocksFemale(ClothesSize size)
        {
            Size = size;
        }
    }
}
