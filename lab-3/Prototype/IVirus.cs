using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.Prototype.VirusTypes;

namespace lab_3.Prototype
{
    public interface IVirus
    {
        public string Name { get; set; }
        public VirusType Type { get; set; }
        public float Weight { get; set; }
        public int AgeInDays { get; set; }
        public List<VirusChild> Childs { get; }
    }
}
