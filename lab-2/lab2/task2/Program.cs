using System.Text;
using task02Library;
namespace task2
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
                Console.WriteLine("Виберіть девайс, який хочете створити (напишіть його):\n" +
                                    "1. Laptop.\n" +
                                    "2. Netbook.\n" +
                                    "3. EBook.\n" +
                                    "4. Smartphone.");
                string deviceType = Console.ReadLine();
                Console.WriteLine("Виберіть бренд (напишіть його):\n" +
                                    "1. iPhrone.\n" +
                                    "2. Kiaomi.\n" +
                                    "3. Balaxy.");
                string brand = Console.ReadLine();


                DeviceFactory factory = new DeviceFactory();
                IDevice device = factory.CreateDevice(deviceType, brand);
                if (device == null)
                {
                    Console.Clear();
                    Console.WriteLine("Помилка введення девайсу");
                    continue;
                }
                else
                {
                    Console.WriteLine("Ваш пристрій:");
                    device.DisplayInfo();
                    check = 1;
                }
            }
        }
    }
}