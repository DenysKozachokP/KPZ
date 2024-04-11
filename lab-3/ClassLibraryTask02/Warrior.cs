using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask02
{
    public class Warrior : Hero
    {
        public override void Attack()
        {
            Console.WriteLine("Воїн атакує мечем");  
        }
    }
}
