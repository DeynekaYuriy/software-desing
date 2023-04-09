using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Decorator.Hero
{
    internal class Warrior : IHero
    {

        public string GetDescription()
        {
            return "Warrior";
        }
    }
}
