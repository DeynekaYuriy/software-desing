using lab_3.AbstractFactory.Clothes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.AbstractFactory.Enums.Sizes;

namespace lab_3.Builder
{
    public class CharacterDirector
    {
        private ICharacterBuilder _builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }
        public void SetBuilder(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public Character MakeNationalist()
        {
            var nationalist = _builder.Called("Nationalist")
                .Tall(180)
                .WithEyesColor("Gray")
                .WithHairColor("Brown")
                .BodyDressedIn(new TShirtMale(ClothesSize.L))
                .HeadDressedIn(new CapMale(ClothesSize.L))
                .InShoes(new ShoesMale(ClothesSize.Size44))
                .GetCharacter();
            return nationalist;
        }
        public Character MakeCommunist()
        {
            var nationalist = _builder.Called("Communist")
                .Tall(144)
                .WithEyesColor("Brown")
                .WithHairColor("Black")
                .BodyDressedIn(new TShirtBaby(ClothesSize.XS))
                .HeadDressedIn(new CapBaby(ClothesSize.XS))
                .InShoes(new ShoesBaby(ClothesSize.Size36))
                .GetCharacter();
            return nationalist;
        }
    }
}
