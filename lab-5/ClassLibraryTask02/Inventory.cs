using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask02
{
    public class Inventory : IInventory
    {
        public void Equip()
        {
            Console.WriteLine("Застосовано базовий інвентар");
        }
    }
}
