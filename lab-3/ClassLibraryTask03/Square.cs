using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask03
{
    public class Square : Shape
    {
        public Square(IDrawAPI api) : base(api) 
        {
        }
        public override void Draw()
        {
            Console.Write("Drawing Square as pixels ===>>>");
            drawAPI.DrawShape();
        }
    }
}
