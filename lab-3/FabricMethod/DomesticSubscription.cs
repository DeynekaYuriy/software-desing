using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.FabricMethod
{
    public class DomesticSubscription : ISubscription
    {
        public float MonthlyFee { get; }
        public uint MinimumPeriod { get; }
        public List<string> Channels { get; }
        public List<string> OtherFeatures { get; }

        public DomesticSubscription()
        {
            MonthlyFee = 5;
            MinimumPeriod = 3;
            Channels = new List<string>() { "Sport Channel", "News Channel", "Music Channel" };
            OtherFeatures = new List<string>() {};
        }
        
    }
}
