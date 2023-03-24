using lab_3.AbstractFactory.Clothes;
using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.AbstractFactory.Enums.Sizes;

namespace lab_3.AbstractFactory.Factories
{
    public class MaleClothesFactory : IClothesFactory
    {
        public IClothes CreateCap(ClothesSize size)
        {
            return new CapMale(size);
        }

        public IClothes CreateShoes(ClothesSize size)
        {
            return new ShoesMale(size);

        }

        public IClothes CreateSocks(ClothesSize size)
        {
            return new SocksMale(size);
        }

        public IClothes CreateTShirt(ClothesSize size)
        {
            return new TShirtMale(size);

        }
    }
}
