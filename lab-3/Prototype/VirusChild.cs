using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.Prototype.VirusTypes;

namespace lab_3.Prototype
{
    public class VirusChild : Virus
    {
        public DateTime BirthDate { get; }
        public IVirus Parent { get; }
        public VirusChild(IVirus parent, string name, DateTime birthDate, VirusType type, float weight, int ageInDays)
            : base(name, type, weight, ageInDays)
        {
            Parent = parent;
            BirthDate = birthDate;
        }
    }
}
