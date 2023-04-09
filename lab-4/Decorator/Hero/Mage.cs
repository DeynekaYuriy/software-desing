using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Decorator.Hero
{
    public class Mage : IHero
    {
        public string GetDescription()
        {
            return "Mage";
        }
    }
}
