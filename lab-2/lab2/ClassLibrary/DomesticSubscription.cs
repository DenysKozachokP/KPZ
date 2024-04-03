using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01Library
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription(int subscriptionPeriod) : base(subscriptionPeriod)
        {
            MonthlyFee = 3;
            Channels.Add("домашні новини");
            Channels.Add("Розваги");
        }

        public override void DisplaySubscriptionInfo()
        {
            Console.WriteLine("Домашня підписка:");
            Console.WriteLine($"Щомісячна плата: {MonthlyFee}$");
            Console.WriteLine($"Мінімальний період підписки: {MinimumSubscriptionPeriod} місяць");
            Console.WriteLine($"Замовлений період підписки: {SubscriptionPeriod} місяць");
            Console.WriteLine("Канали:");
            foreach (var channel in Channels)
            {
                Console.WriteLine(channel);
            }
        }
    }
}
