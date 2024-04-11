using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask03
{
    public class Triangle : Shape
    {
        public Triangle(IDrawAPI api) : base(api) { }
        public override void Draw()
        {
            Console.Write("Drawing Triangle as pixels ===>>>");
            drawAPI.DrawShape();
        }
    }
}
