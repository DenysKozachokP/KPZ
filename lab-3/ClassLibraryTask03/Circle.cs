using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask03
{
    public class Circle : Shape
    {
        public Circle(IDrawAPI api) : base(api) 
        {
        }
        public override void Draw()
        {
            Console.Write("Drawing Circle as pixels ===>>>");
            drawAPI.DrawShape();
        }
    }
}
