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
        public virtual void OnCreated()
        {
            Console.WriteLine($"Node created: {GetType().Name}");
        }

        public virtual void OnInserted()
        {
            Console.WriteLine($"Node inserted: {GetType().Name}");
        }

        public virtual void OnRemoved()
        {
            Console.WriteLine($"Node removed: {GetType().Name}");
        }

        public virtual void OnStylesApplied()
        {
            Console.WriteLine($"Styles applied to node: {GetType().Name}");
        }

        public virtual void OnClassListApplied()
        {
            Console.WriteLine($"Classes applied to node: {GetType().Name}");
        }

        public virtual void OnTextRendered()
        {
            Console.WriteLine($"Text rendered for node: {GetType().Name}");
        }
        public override void Accept(IHtmlVisitor visitor)
        {
            visitor.VisitParagraphNode(this);
        }
    }
}
