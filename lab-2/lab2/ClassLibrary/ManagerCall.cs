using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01Library
{
    public class ManagerCall : SubscriptionBuy
    {
        public ManagerCall()
        {
            Console.WriteLine("Менеджер пропонує вам такі підписки");
        }
        public override Subscription BuySubscription(int subscriptionLevel, int subscriptionPeriod)
        {
            switch (subscriptionLevel)
            {
                case 1:
                    return new DomesticSubscription( subscriptionPeriod);
                    break;
                case 2:
                    return new EducationalSubscription(subscriptionPeriod);
                    break;
                case 3:
                    return new PremiumSubscription(subscriptionPeriod);
                    break;
                default:
                    return null;
            }
        }
    }
}
