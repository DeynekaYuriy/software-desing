using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Builder
{
    public class Character
    {
        public string? Name { get; set; }
        public float Height { get; set; }
        public string? HairColor { get; set; }
        public string? EyesColor { get; set; }
        public CharacterSuit Suit { get; set; } = new();

        public override string ToString()
        {
            StringBuilder descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Name: {Name}")
                .AppendLine($"Height: {Height} cm")
                .AppendLine($"Hair color: {HairColor}")
                .AppendLine($"Eyes color: {EyesColor}")
                .AppendLine($"Suit: {Suit.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
    
}
