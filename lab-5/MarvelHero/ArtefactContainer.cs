using DesignPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.MarvelHero
{
    public class ArtefactContainer : IArtefactContainer
    {
        private List<Artefact> children = new List<Artefact>();

        public int GetWeight()
        {
            return this.children.Aggregate(0, (sum, next) => sum += next.GetWeight());
        }

        public int GetPowerBuf()
        {
            return this.children.Aggregate(0, (sum, next) => sum += next.GetPowerBuf());
        }

        public int GetCount()
        {
            return this.children.Aggregate(0, (sum, next) => sum += next.GetCount());
        }

        public void AddArtefact(Artefact artefact)
        {
            children.Add(artefact);
        }

        public void RemoveArtefact(Artefact artefact)
        {
            children.Remove(artefact);
        }
    }
}
