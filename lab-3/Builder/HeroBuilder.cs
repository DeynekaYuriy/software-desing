using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _hero;

        public HeroBuilder()
        {
            _hero = new Character();
        }
        private void reset()
        {
            _hero = new Character();
        }
        public Character GetCharacter()
        {
            var hero = _hero;
            reset();
            return hero;
        }
        public ICharacterBuilder BodyDressedIn(IClothes clothes)
        {
            _hero.Suit.Body = clothes;
            return this;
        }

        public ICharacterBuilder BottomDressedIn(IClothes clothes)
        {
            _hero.Suit.Bottom = clothes;
            return this;
        }

        public ICharacterBuilder Called(string name)
        {
            _hero.Name = name;
            return this;
        }

        public ICharacterBuilder HeadDressedIn(IClothes clothes)
        {
            _hero.Suit.Head = clothes;
            return this;
        }

        public ICharacterBuilder Tall(float height)
        {
            _hero.Height = height;
            return this;
        }

        public ICharacterBuilder InShoes(IClothes clothes)
        {
            _hero.Suit.Shoes = clothes;
            return this;
        }

        public ICharacterBuilder WithEyesColor(string color)
        {
            _hero.EyesColor = color;
            return this;
        }

        public ICharacterBuilder WithHairColor(string color)
        {
            _hero.HairColor = color;
            return this;
        }
    }
}
