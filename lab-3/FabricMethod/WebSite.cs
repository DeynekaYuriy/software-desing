using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.FabricMethod
{
    public class WebSite
    {
        public WebSite()
        {

        }
        public ISubscription Subscribe(ISubscriptionCreator creator)
        {
            return creator.CreateSubscription();
        }
    }
}
