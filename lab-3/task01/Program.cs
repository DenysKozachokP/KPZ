using ClassLibraryTask01;
using System.Text;
namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Logger logger = new Logger();
            FileWriter fileWriter = new FileWriter();
            FileLogger fileLogger = new FileLogger(fileWriter, logger);
            fileLogger.Log("Лог-повідомлення");
            fileLogger.Error("Повідомлення про помилку");
            fileLogger.Warn("Попереджувальне повідомлення");
        }
    }
}