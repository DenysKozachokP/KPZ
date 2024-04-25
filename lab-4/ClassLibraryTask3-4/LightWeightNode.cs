using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask3_4
{
    public class LightWeightNode : LightNode
    {
        public string TagName { get; set; }
        public string Content { get; set; }

        public override string OuterHtml
        {
            get
            {
                return $"<{TagName}>{Content}</{TagName}>";
            }
        }

        public override string InnerHtml
        {
            get { return Content; }
        }

        public LightWeightNode(string tagName, string content)
        {
            TagName = tagName;
            Content = content;
        }
    }
}
