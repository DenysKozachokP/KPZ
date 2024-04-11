using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask02
{
    public class Paladin : Hero
    {
        public override void Attack()
        {
            Console.WriteLine("Паладін атакує молотом");
        }
    }
}
