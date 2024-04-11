using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask05_06
{
    public class BookToHTMLConverter
    {
        public LightHTML ConvertToHTML(string bookText)
        {
            var root = new LightWeightNode("div", "");

            foreach (var line in bookText.Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var tag = line.Length < 20 ? "h2" : line.StartsWith(" ") ? "blockquote" : "p";
                root.Content += new LightWeightNode(tag, line.Trim()).OuterHtml;
            }

            return new LightHTML(root);
        }
    }
}
