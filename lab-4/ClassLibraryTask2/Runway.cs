using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask2
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusy;

        public void HighLightRed()
        {
            Console.WriteLine($"Взлітна смуга {Id} зайнята!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Взлітна смуга {Id} вільна!");
        }
    }
}
