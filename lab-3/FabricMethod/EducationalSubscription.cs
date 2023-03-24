using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.FabricMethod
{
    public class EducationalSubscription : ISubscription
    {
        public float MonthlyFee { get; }
        public uint MinimumPeriod { get; }
        public List<string> Channels { get; }
        public List<string> OtherFeatures { get; }

        public EducationalSubscription()
        {
            MonthlyFee = 2.5f;
            MinimumPeriod = 6;
            Channels = new List<string>() { "Sport Channel", "News Channel", "Music Channel", "Education Channel", "Documentary Channel" };
            OtherFeatures = new List<string>() { "Offline" };
        }
    }
}
