using System.Text;
using task01Library;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int check = 0;
            while (check == 0)
            {
                Console.WriteLine("Оберіть ваш метод оплати:\n" +
                                    "1. Веб-сайт.\n" +
                                    "2. Мобільний додаток.\n" +
                                    "3. Дзвінок менеджера\n");

                int paymentMethod;
                if (!int.TryParse(Console.ReadLine(), out paymentMethod))
                {
                    Console.Clear();
                    Console.WriteLine("Помилка, спробуйте ще раз ввести бажаний метод оплати");
                    continue;
                }

                SubscriptionBuy payment = null;
                switch (paymentMethod)
                {
                    case 1:
                        payment = new WebSite();
                        break;
                    case 2:
                        payment = new MobileApp();
                        break;
                    case 3:
                        payment = new ManagerCall();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Помилка, спробуйте ще раз ввести бажаний метод оплати");
                        continue;
                }

                Console.WriteLine("Оберіть ваш план підписки:\n" +
                                "1. Домашня підписка.\n" +
                                "2. Освітня підписка.\n" +
                                "3. Преміум-підписка");

                int subscriptionPlan;
                if (!int.TryParse(Console.ReadLine(), out subscriptionPlan) || subscriptionPlan < 1 || subscriptionPlan > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Помилка, спробуйте ще раз ввести бажаний план підписки та метод оплати.");
                    continue;
                }

                Console.WriteLine("Введіть бажаний період підписки:");
                int subscriptionPeriod;
                if (!int.TryParse(Console.ReadLine(), out subscriptionPeriod) || subscriptionPeriod <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Помилка, спробуйте ще раз ввести бажаний період підписки, план підписки та метод оплати");
                    continue;
                }

                Subscription subscription = payment.BuySubscription(subscriptionPlan, subscriptionPeriod);
                if (subscription == null)
                {
                    Console.Clear();
                    Console.WriteLine("Помилка, спробуйте ще раз ввести бажаний період підписки, план підписки та метод оплати");
                    continue;
                }
                else
                {
                    Console.WriteLine("Інформація про підписку:");
                    subscription.DisplaySubscriptionInfo();
                    check = 1;
                }
            }
        }
    }
}