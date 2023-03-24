using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Builder
{
    public interface ICharacterBuilder
    {
        public ICharacterBuilder Called(string name);
        public ICharacterBuilder Tall(float height);
        public ICharacterBuilder WithHairColor(string color);
        public ICharacterBuilder WithEyesColor(string color);
        public ICharacterBuilder HeadDressedIn(IClothes clothes);
        public ICharacterBuilder BodyDressedIn(IClothes clothes);
        public ICharacterBuilder BottomDressedIn(IClothes clothes);
        public ICharacterBuilder InShoes(IClothes clothes);
        public Character GetCharacter();

    }
}
