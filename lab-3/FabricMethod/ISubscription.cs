using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.FabricMethod
{
    public interface ISubscription
    {
        public float MonthlyFee { get; }
        public uint MinimumPeriod { get; }
        public List<string> Channels { get; }
        public List<string> OtherFeatures { get; }
    }
}
