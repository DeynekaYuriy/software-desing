using lab_4.Decorator.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Decorator
{
    public class ClothesInventory : InventoryDecorator
    {
        private string _clothesName;
        public ClothesInventory(string clothesName, IHero hero) : base(hero)
        {
            _clothesName = clothesName;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + $" dressed in {_clothesName}";
        }
    }
}
