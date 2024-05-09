using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask02
{
    public class ArtifactDecorator : IInventory
    {
        private readonly IInventory _inventory;
        public ArtifactDecorator(IInventory inventory)
        {
            this._inventory = inventory;
        }
        public void Equip()
        {
            this._inventory.Equip();
            Console.WriteLine("Екіперовано артефакт");
        }
    }
}
