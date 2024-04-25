using System;
using System.Text;
using ClassLibraryTask3_4;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            var converter = new BookToHTMLConverter();
            var bookText = "Після сессії хочу поїхати \n\nimg https://amazing-ukraine.com/wp-content/uploads/2021/09/thumb_744_location_photo_big.jpeg , text\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit.";
            var html = converter.ConvertToHTML(bookText);
            Console.WriteLine(html.GetHtml());
        }
    }
}