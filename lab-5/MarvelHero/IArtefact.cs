using DesignPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.MarvelHero
{
    public interface IArtefact
    {
        public int GetWeight();
        public int GetPowerBuf();
        public int GetCount();
    }
    public interface IArtefactContainer : IArtefact
    {
        public void AddArtefact(Artefact artefact);
        public void RemoveArtefact(Artefact artefact);
    }
}
