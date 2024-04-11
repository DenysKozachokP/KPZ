using ClassLibraryTask02;
using System.Text;
namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            IInventory inventory = SetupInventory();

            DisplayHeroActions("Warrior", () =>
            {
                Hero warrior = new Warrior();
                warrior.SetInventory(inventory);
                warrior.Attack();
                warrior.inventory.Equip();
            });

            DisplayHeroActions("Mage", () =>
            {
                Hero mage = new Mage();
                mage.SetInventory(inventory);
                mage.Attack();
                mage.inventory.Equip();
            });

            DisplayHeroActions("Paladin", () =>
            {
                Hero paladin = new Paladin();
                paladin.SetInventory(inventory);
                paladin.Attack();
                paladin.inventory.Equip();
            });

            Console.ReadLine();
        }

        static IInventory SetupInventory()
        {
            IInventory inventory = new Inventory();
            inventory = new WeaponDecorator(inventory);
            inventory = new ArmorDecorator(inventory);
            inventory = new ArtifactDecorator(inventory);
            return inventory;
        }

        static void DisplayHeroActions(string heroType, Action action)
        {
            Console.WriteLine($"===== {heroType} =====");
            action.Invoke();
            Console.WriteLine();
        }
    }
}