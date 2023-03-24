using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static lab_3.Prototype.VirusTypes;

namespace lab_3.Prototype
{
    public class Virus : IVirusClonable
    {
        public string Name { get; set; }
        public VirusType Type { get; set; }
        public float Weight { get; set; }
        public int AgeInDays { get; set; }
        public List<VirusChild> Childs { get; } = new();
        public Virus(string name, VirusType type, float weight, int ageInDays)
        {
            Name = name;
            Type = type;
            Weight = weight;
            AgeInDays = ageInDays;
        }

        public IVirusClonable Clone(string childName)
        {
            var child = new VirusChild(this, childName, DateTime.Now, Type, Weight, 0);
            Childs.Add(child);
            return child;
        }

        public string GetVirusChilds(int shift = 0)
        {
            var childsStringBuilder = new StringBuilder();
            foreach (var child in this.Childs)
            {
                childsStringBuilder.Append($"\n{new string(' ', shift * 2)}- {child.Name}");
                if (child.Childs.Count != 0)
                {
                    childsStringBuilder.Append(":");
                    childsStringBuilder.Append(child.GetVirusChilds(shift + 1));
                }
            }
            return childsStringBuilder.ToString();
        }
    }
}
