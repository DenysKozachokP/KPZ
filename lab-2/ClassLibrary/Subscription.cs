namespace task01Library
{
    public abstract class Subscription
    {
        protected double MonthlyFee { get; set; }
        protected int MinimumSubscriptionPeriod { get; set; }
        protected int SubscriptionPeriod { get; set; }
        protected List<string> Channels { get; set; }

        public Subscription(int subscriptionPeriod)
        {
            MonthlyFee = 2.99;
            MinimumSubscriptionPeriod = 1;
            SubscriptionPeriod = subscriptionPeriod;
            Channels = new List<string>();
        }

        public abstract void DisplaySubscriptionInfo();
    }
}
