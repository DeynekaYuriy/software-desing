using lab_4.Decorator.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Decorator
{
    public class WeaponInventory : InventoryDecorator
    {
        private string _weaponName;
        public WeaponInventory(string weaponName, IHero hero) : base(hero)
        {
            _weaponName = weaponName;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + $" with {_weaponName} weapon";
        }
    }
}
