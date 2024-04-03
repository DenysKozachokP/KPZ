using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01Library
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(int subscriptionPeriod) : base(subscriptionPeriod)
        {
            MonthlyFee = 2;
            Channels.Add("Освітній контент");
            Channels.Add("Документальна література");
        }

        public override void DisplaySubscriptionInfo()
        {
            Console.WriteLine("Освітня підписка:");
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
