using lab_4.Decorator.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Decorator
{
    public class ArtifactInventory : InventoryDecorator
    {
        private string _artifactName;
        public ArtifactInventory(string artifactName, IHero hero) : base(hero)
        {
            _artifactName = artifactName;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $" with {_artifactName} artifact";
        }
    }
}
