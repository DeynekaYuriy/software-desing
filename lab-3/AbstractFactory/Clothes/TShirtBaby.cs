using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.AbstractFactory.Enums.Sizes;

namespace lab_3.AbstractFactory.Clothes
{
    public class TShirtBaby : IClothes
    {
        public string Name => "Baby T-Shirt";

        public ClothesSize Size { get; }
        public TShirtBaby(ClothesSize size)
        {
            Size = size;
        }
    }
}
