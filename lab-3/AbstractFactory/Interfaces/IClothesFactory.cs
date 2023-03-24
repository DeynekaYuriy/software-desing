using lab_3.AbstractFactory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.AbstractFactory.Enums.Sizes;

namespace lab_3.AbstractFactory.Interfaces
{
    public interface IClothesFactory 
    {
        public IClothes CreateSocks(ClothesSize size);
        public IClothes CreateTShirt(ClothesSize size);
        public IClothes CreateShoes(ClothesSize size);
        public IClothes CreateCap(ClothesSize size);
    }
}
