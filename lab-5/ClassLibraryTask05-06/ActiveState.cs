using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibraryTask05_06
{
    class ActiveState : ElementState
    {
        public ActiveState(string element) : base(element) { }

        public override void Handle()
        {
            Console.WriteLine($"Element {_element} is active.");
        }
    }
}