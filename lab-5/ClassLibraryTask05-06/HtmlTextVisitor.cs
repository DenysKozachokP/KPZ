using ClassLibraryForTask3_4;
using ClassLibraryForTask5_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask05_06
{
    public class HtmlTextVisitor : IHtmlVisitor
    {
        private StringBuilder _result = new StringBuilder();

        public string GetHtmlText()
        {
            return _result.ToString();
        }

        public void VisitElementNode(LightElementNode elementNode)
        {
            _result.Append($"<{elementNode.TagName}>");
            foreach (var child in elementNode.Children)
            {
                child.Accept(this);
            }
            _result.Append($"</{elementNode.TagName}>");
        }

        public void VisitTextNode(LightTextNode textNode)
        {
            _result.Append(textNode.Text);
        }

        public void VisitBlockquoteNode(LightBlockquoteNode blockquote)
        {
            Console.WriteLine($"Visiting blockquote: {blockquote.Text}");
        }

        public void VisitHeaderNode(LightHeaderNode header)
        {
            Console.WriteLine($"Visiting header: {header.Text}");
        }

        public void VisitImageNode(LightImageNode image)
        {
            Console.WriteLine($"Visiting image: {image.Href}");
        }

        public void VisitParagraphNode(LightParagraphNode paragraph)
        {
            Console.WriteLine($"Visiting paragraph: {paragraph.Text}");
        }

        public void VisitSecondHeaderNode(LightSecondHeaderNode secondHeader)
        {
            Console.WriteLine($"Visiting second header: {secondHeader.Text}");
        }
    }
}