using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _enemy;

        public EnemyBuilder()
        {
            _enemy = new Character();
        }
        private void reset()
        {
            _enemy = new Character();
        }
        public Character GetCharacter()
        {
            var hero = _enemy;
            reset();
            return hero;
        }
        public ICharacterBuilder BodyDressedIn(IClothes clothes)
        {
            _enemy.Suit.Body = clothes;
            return this;
        }

        public ICharacterBuilder BottomDressedIn(IClothes clothes)
        {
            _enemy.Suit.Bottom = clothes;
            return this;
        }

        public ICharacterBuilder Called(string name)
        {
            _enemy.Name = name;
            return this;
        }

        public ICharacterBuilder HeadDressedIn(IClothes clothes)
        {
            _enemy.Suit.Head = clothes;
            return this;
        }

        public ICharacterBuilder Tall(float height)
        {
            _enemy.Height = height;
            return this;
        }

        public ICharacterBuilder InShoes(IClothes clothes)
        {
            _enemy.Suit.Shoes = clothes;
            return this;
        }

        public ICharacterBuilder WithEyesColor(string color)
        {
            _enemy.EyesColor = color;
            return this;
        }

        public ICharacterBuilder WithHairColor(string color)
        {
            _enemy.HairColor = color;
            return this;
        }

    }
}
