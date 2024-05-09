using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask04
{
    public class SmartTextChecker : ITextReader
    {
        private readonly SmartTextReader _textReader;

        public SmartTextChecker()
        {
            _textReader = new SmartTextReader();
        }

        public string[][] ReadText(string filePath)
        {
            Console.WriteLine("Open file");

            var result = _textReader.ReadText(filePath);

            Console.WriteLine("The file was read successfully!");
            Console.WriteLine($"Number of rows: {result.Length}");

            int totalChars = 0;
            foreach (var line in result)
            {
                totalChars += line.Length;
            }

            Console.WriteLine($"The number of letters: {totalChars}");
            Console.WriteLine("Close file");

            return result;
        }
    }
}
