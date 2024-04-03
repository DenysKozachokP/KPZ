using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02Library
{
    public class Smartphone : IDevice
    {
        private string Brand { get; }
        public Smartphone(string brand)
        {
            Brand = brand;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Smartphone - {Brand}");
        }
    }
}
