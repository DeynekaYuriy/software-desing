using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.MarvelHero.Logger
{
    public interface IArtefactLogger
    {
        public void Added(int count);
        public void Removed(int count);
    }
}
