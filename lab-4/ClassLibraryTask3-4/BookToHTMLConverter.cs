using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask3_4
{
    public class BookToHTMLConverter
    {
        public LightHTML ConvertToHTML(string bookText)
        {
            var lines = bookText.Split('\n');
            var root = new LightWeightNode("div", "");

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                LightNode node;

                if (line.Length < 20)
                {
                    node = new LightWeightNode("h2", line);
                }
                else if (line.StartsWith(" "))
                {
                    node = new LightWeightNode("blockquote", line.Trim());
                }
                else if (line.StartsWith("img"))
                {
                    var imgInfo = line.Substring(3).Split(',');
                    if (imgInfo.Length >= 2)
                    {
                        string src = imgInfo[0];
                        string alt = imgInfo[1];
                        Console.WriteLine($"{src}, {alt} \n\n\n");
                        var imgNode = new LightImageNode(src, alt);
                        imgNode.LoadImage();
                        node = imgNode;
                    }
                    else
                    {
                        node = new LightTextNode(line);
                    }
                }
                else
                {
                    node = new LightWeightNode("p", line);
                }

                root.Content += node.OuterHtml;
            }

            var html = new LightHTML(root);
            html.AddEventListener("click", () => Console.WriteLine("Element clicked!"));
            return html;
        }
    }
}
