using System;
using System.Collections.Generic;
namespace ClassLibraryTask05_06
{
    class CustomHtmlProcessor : HtmlProcessor
    {
        protected override List<string> ExtractElements(string html)
        {
            List<string> elements = new List<string>();

            int startIndex = 0;
            while (true)
            {

                int openIndex = html.IndexOf('<', startIndex);
                int closeIndex = html.IndexOf('>', startIndex);

                if (openIndex == -1 || closeIndex == -1)
                    break;

                elements.Add(html.Substring(openIndex, closeIndex - openIndex + 1));


                startIndex = closeIndex + 1;
            }

            return elements;
        }
        protected override void ProcessElement(string element)
        {
            Console.WriteLine($"Processing element: {element}");
        }
    }
}