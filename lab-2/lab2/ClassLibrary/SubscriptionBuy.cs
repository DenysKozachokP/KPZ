using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01Library
{
    public abstract class SubscriptionBuy
    {
        private int SubscriptionLevel { get; set; }
        public abstract Subscription BuySubscription(int subscriptionLevel, int subscriptionPeriod);
    }
}
