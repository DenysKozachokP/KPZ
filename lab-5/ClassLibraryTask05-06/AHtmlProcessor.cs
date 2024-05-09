using System;
using System.Collections.Generic;
namespace ClassLibraryTask05_06
{
    abstract class HtmlProcessor
    {
        public void ProcessHtml(string html)
        {
            List<string> elements = ExtractElements(html);
            foreach (var element in elements)
            {
                ProcessElement(element);
            }
        }
        protected virtual List<string> ExtractElements(string html)
        {
            return new List<string>();
        }
        protected abstract void ProcessElement(string element);
    }
}
