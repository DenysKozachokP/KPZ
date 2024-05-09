using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask05_06
{
    public class LightHTML
    {
        public LightNode Root { get; set; }

        public LightHTML(LightNode root)
        {
            Root = root;
        }

        public string GetHtml()
        {
            return Root.OuterHtml;
        }
    }
}
