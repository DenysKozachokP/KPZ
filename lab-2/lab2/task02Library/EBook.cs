using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02Library
{
    public class EBook : IDevice
    {
        private string Brand { get; }
        public EBook(string brand)
        {
            Brand = brand;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"EBook - {Brand}");
        }
    }
}
