using System;
using System.Text;
using ClassLibraryTask5;
namespace task5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            TextEditor editor = new TextEditor("Текст 11");
            editor.Display();
            editor.Edit("Текст 22");
            editor.Display();
            editor.Undo();
            editor.Display();
        }
    }
}