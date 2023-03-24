using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.FabricMethod
{
    internal class PremiumSubscription : ISubscription
    {

        public float MonthlyFee { get; }
        public uint MinimumPeriod { get; }
        public List<string> Channels { get; }
        public List<string> OtherFeatures { get; }

        public PremiumSubscription()
        {
            MonthlyFee = 10;
            MinimumPeriod = 3;
            Channels = new List<string>() { "Sport Channel", "News Channel", "Music Channel", "Education Channel", "Documentary Channel",
            "Premium Channel", "Premium Channel"};
            OtherFeatures = new List<string>() { "Offline", "4K" };
        }

    }
}
