using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.AbstractFactory.Enums.Sizes;

namespace lab_3.AbstractFactory.Clothes
{
    public class TShirtFemale : IClothes
    {
        public string Name => "Female T-Shirt";

        public ClothesSize Size { get; }
        public TShirtFemale(ClothesSize size)
        {
            Size = size;
        }
    }
}
