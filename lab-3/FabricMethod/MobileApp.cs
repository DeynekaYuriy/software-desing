using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.FabricMethod
{
    public class MobileApp
    {
        public MobileApp() { }
        public ISubscription Subscribe(ISubscriptionCreator creator)
        {
            return creator.CreateSubscription();
        }
    }
}
