using ClassLibraryTask05_06;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Text;
namespace task06
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookText = "The Project Gutenberg eBook of Romeo and Juliet " +
                "This ebook is for the use of anyone anywhere in the United States and" +
                "most other parts of the world at no cost and with almost no restrictions" +
                "whatsoever.You may copy it, give it away or re-use it under the terms" +
                "of the Project Gutenberg License included with this ebook or online" +
                "at www.gutenberg.org.If you are not located in the United States," +
                "you will have to check the laws of the country where you are locatedbefore " +
                "using this eBook.\n" +
                "\n" +
                " Title: Romeo and Juliet\n" +
                " Author: William Shakespeare\n" +
                "\n" +
                " Release date: November 1, 1998[eBook #1513]\n" +
                " Most recently updated: June 27, 2023\n" +
                "\n" +
                " Language: English\n" +
                " Credits: the PG Shakespeare\n" +
                " Team, a team of about twenty Project Gutenberg volunteers\n" +
                "\n" +
                "***START OF THE PROJECT GUTENBERG EBOOK ROMEO AND JULIET ***\n" +
                "\n" +
                "\n" +
                " THE TRAGEDY OF ROMEO AND JULIET\n" +
                "\n" +
                " by William Shakespeare\n";

            BookToHTMLConverter converter = new BookToHTMLConverter();
            LightHTML html = converter.ConvertToHTML(bookText);

            Console.WriteLine(html.GetHtml());
        }
    }
}