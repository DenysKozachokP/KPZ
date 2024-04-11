using ClassLibraryTask03;
using System.Text;
namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            IDrawAPI vectorDrawAPI = new VectorDrawAPI();
            IDrawAPI rasterDrawAPI = new RasterDrawAPI();

            Shape circle = new Circle(vectorDrawAPI);
            Shape square = new Square(rasterDrawAPI);
            Shape triangle = new Triangle(vectorDrawAPI);

            circle.Draw();
            square.Draw();
            triangle.Draw();

            Console.ReadLine();
        }
    }
}