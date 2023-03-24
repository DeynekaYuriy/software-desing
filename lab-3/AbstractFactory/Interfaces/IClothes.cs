using lab_3.AbstractFactory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.AbstractFactory.Enums.Sizes;

namespace lab_3.AbstractFactory.Interfaces
{
    
    public interface IClothes
    {
        public string Name { get; }
        public ClothesSize Size { get; }
    }
}
