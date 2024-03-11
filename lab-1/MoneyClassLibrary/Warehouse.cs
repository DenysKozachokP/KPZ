using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyClassLibrary
{
    public class Warehouse
    {
        private List<WHStorage> _items = new List<WHStorage>();

        public void AddItem(WHStorage item)
        {
            _items.Add(item);
        }

        public IEnumerable<WHStorage> GetInventory()
        {
            return _items;
        }
    }
}
