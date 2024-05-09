using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask05_06
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; }
        public string ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, List<LightNode> children, List<string> cssClasses = null)
        {
            TagName = tagName;
            Children = children ?? new List<LightNode>();
            CssClasses = cssClasses ?? new List<string>();
        }

        public override void Accept(IHtmlVisitor visitor)
        {
            visitor.VisitElementNode(this);
            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
        }

        public override string OuterHtml
        {
            get
            {
                string classes = CssClasses != null ? string.Join(" ", CssClasses) : "";
                string childrenHtml = Children != null ? string.Join("", Children.Select(child => child.OuterHtml)) : "";
                string closingTag = ClosingType == "single" ? "/>" : $">{childrenHtml}</{TagName}>";

                return $"<{TagName} class=\"{classes}\"{closingTag}";
            }
        }

        public override string InnerHtml
        {
            get
            {
                return Children != null ? string.Join("", Children.Select(child => child.OuterHtml)) : "";
            }
        }

        
    }
}
