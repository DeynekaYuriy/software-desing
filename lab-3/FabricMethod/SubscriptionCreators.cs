using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.FabricMethod
{
    public interface ISubscriptionCreator
    {
        public ISubscription CreateSubscription();
    }
    public class DomesticSubscriptionCreator : ISubscriptionCreator
    {
        public ISubscription CreateSubscription()
        {
            return new DomesticSubscription();
        }
    }
    public class PremiumSubscriptionCreator : ISubscriptionCreator
    {
        public ISubscription CreateSubscription()
        {
            return new PremiumSubscription();
        }
    }
    public class EducationalSubscriptionCreator : ISubscriptionCreator
    {
        public ISubscription CreateSubscription()
        {
            return new EducationalSubscription();
        }
    }
}
