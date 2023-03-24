using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Prototype
{
    public interface IVirusClonable : IVirus
    {
        public IVirusClonable Clone(string name);
        public string GetVirusChilds(int shift = 0);
    }
}
