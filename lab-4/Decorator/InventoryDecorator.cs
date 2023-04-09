using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_4.Decorator.Hero;

namespace lab_4.Decorator
{
    abstract public class InventoryDecorator : IHero
    {
        protected IHero _hero;
        public InventoryDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual string GetDescription()
        {
            return _hero.GetDescription();
        }
    }
}
