using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01Library
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription( int subscriptionPeriod) : base(subscriptionPeriod)
        {
            MonthlyFee = 10.99;
            Channels.Add("Всі канали");
            Channels.Add("Весь контент без обмежень");
        }

        public override void DisplaySubscriptionInfo()
        {
            Console.WriteLine("Преміум підписка:");
            Console.WriteLine($"Щомісячна плата: {MonthlyFee}$");
            Console.WriteLine($"Мінімальний період підписки: {MinimumSubscriptionPeriod} місяць");
            Console.WriteLine($"Замовлений період підписки: {SubscriptionPeriod} місяць");
            Console.WriteLine("канали:");
            foreach (var channel in Channels)
            {
                Console.WriteLine(channel);
            }
        }
    }
}
