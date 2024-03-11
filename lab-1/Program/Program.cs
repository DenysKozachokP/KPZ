using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MoneyClassLibrary;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var dollar = new Dollar(0, 0);
            var euro = new UAH(0, 0);

            var PC = new Product("Клавіатура", new Money(new Dollar(100, 0)), "Електронiка");
            var phone = new Product("Телефон", new Money(new UAH(200, 70)), "Електронiка");
            var mouse = new Product("Безпровідна мишка", new Money(new UAH(70, 25)), "Електронiка");
            var wardrobe = new Product("Шафа купе", new Money(new UAH(700, 0)), "Меблі");
            var chair = new Product("Стілець", new Money(new Dollar(50, 25)), "Меблі");
            var clothes = new Product("Штани", new Money(new UAH(80, 90)), "Одяг");

            var discountAmountCents = 3 * 100 + 25;
            clothes.ReducePrice(discountAmountCents);

            var products = new List<Product> { PC, phone, mouse, wardrobe, chair, clothes };

            Console.WriteLine("Всі продукти:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Category} - Ціна: {product.Price}");
            }

            var warehouse = new Warehouse();
            var reporting = new Reporting(warehouse);

            Console.WriteLine("\nРеєстрація надходження товару:");
            var arrivals = new Dictionary<string, int>
            {
                { "Клавіатура", 10 },
                { "Телефон", 10 },
                { "Безпровідна мишка", 300 },
                { "Шафа купе", 20 },
                { "Стілець", 99 },
                { "Штани", 8 }
            };

            foreach (var arrival in arrivals)
            {
                reporting.RegisterArrival(new WHStorage(products.First(p => p.Name == arrival.Key), arrival.Value, DateTime.Now));
            }

            Console.WriteLine("\n#Інформація про склад#");
            foreach (var item in reporting.InventoryReport())
            {
                Console.WriteLine($"{item.Product.Name}: {item.Quantity} шт.");
            }

            Console.WriteLine("\nОформлення відправлення товару:");
            var shipments = new Dictionary<string, int>
            {
                { "Комп'ютер", 2 },
                { "Телефон", 5 },
                { "Безпровідна мишка", 90 },
                { "Шафа купе", 19 },
                { "Стілець", 89 },
                { "Штани", 3 }
            };

            foreach (var shipment in shipments)
            {
                reporting.RegisterShipment(shipment.Key, shipment.Value);
            }

            Console.WriteLine("\n#Інформація про склад#");
            foreach (var item in reporting.InventoryReport())
            {
                Console.WriteLine($"{item.Product.Name}: {item.Quantity} шт.");
            }

            Console.WriteLine("\nПродукти в категорії \"Електронiка\":");
            var electronicProducts = products.Where(p => p.Category == "Електронiка");
            foreach (var product in electronicProducts)
            {
                Console.WriteLine($"{product.Name} - Ціна: {product.Price}");
            }

            Console.WriteLine("Вся звітність:");
            reporting.PrintAllInvoices();

            Console.ReadLine();
        }
    }

}
