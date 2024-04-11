using ClassLibraryTask04;
using System.Text;
namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            ITextReader reader = new SmartTextChecker(); 

            string filePath = @"D:\Навчання_2_курс\Констроювання програмного\KPZ\lab-3\sample.txt"; 

            string[][] textArray = reader.ReadText(filePath);

            foreach (var line in textArray)
            {
                foreach (var word in line)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}