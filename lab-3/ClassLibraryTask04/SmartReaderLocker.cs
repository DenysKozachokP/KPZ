using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryTask04
{
    public class SmartReaderLocker : ITextReader
    {
        private SmartTextReader textReader;
        private Regex regex;
        public SmartReaderLocker(string pattern)
        {
            textReader = new SmartTextReader();
            regex = new Regex(pattern);
        }
        public string[][] ReadText(string filePath)
        {
            if (regex.IsMatch(filePath))
            {
                Console.WriteLine("Access is denied!");
                return new string[0][];
            }
            else
            {
                return textReader.ReadText(filePath);
            }
        }
    }
}
