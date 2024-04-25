using System;
using System.Text;
using ClassLibraryTask1;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=Encoding.Unicode;
            Console.OutputEncoding=Encoding.Unicode;

            SupportSystem supportSystem = new SupportSystem();

            Console.WriteLine("Ласкаво просимо до системи підтримки користувачів!");
            while (true)
            {
                supportSystem.ShowMenu();
                if (supportSystem.HandleUserInput())
                    break;
            }
        }
    }
}