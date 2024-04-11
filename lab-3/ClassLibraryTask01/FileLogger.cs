using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask01
{
    public class FileLogger : Logger
    {
        private readonly FileWriter fileWriter;
        private readonly Logger _logger;
        public FileLogger(FileWriter fileWriter, Logger logger)
        {
            this.fileWriter = fileWriter;
            this._logger = logger;
        }
        public new void Log(string text)
        {
            this._logger.Log(text);
            this.fileWriter.WriteLine(text);
            Console.ResetColor();

        }
        public new void Error(string text)
        {
            this._logger.Error(text);
            this.fileWriter.WriteLine(text);
            Console.ResetColor();
        }
        public new void Warn(string text)
        {
            this._logger.Warn(text);
            this.fileWriter.WriteLine(text);
            Console.ResetColor();
        }
    }
}
