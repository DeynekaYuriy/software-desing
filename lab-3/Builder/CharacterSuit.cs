using lab_3.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_3.Builder
{
    public class CharacterSuit
    {
        public IClothes? Head { get; set; }
        public IClothes? Body { get; set; }
        public IClothes? Bottom { get; set; }
        public IClothes? Shoes { get; set; }

        public override string ToString()
        {
            StringBuilder descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Head: {Head?.Name}")
                .AppendLine($"Body: {Body?.Name}")
                .AppendLine($"Bottom: {Bottom?.Name}")
                .AppendLine($"Shoes: {Shoes?.Name}");
            return descriptionBuilder.ToString();
        }
    }
}
