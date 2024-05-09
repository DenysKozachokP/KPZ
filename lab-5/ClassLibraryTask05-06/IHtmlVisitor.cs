using ClassLibraryForTask3_4;
using ClassLibraryForTask5_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask05_06
{
    public interface IHtmlVisitor
    {
        void VisitElementNode(LightElementNode elementNode);
        void VisitTextNode(LightTextNode textNode);
        void VisitBlockquoteNode(LightBlockquoteNode blockquote);
        void VisitHeaderNode(LightHeaderNode header);
        void VisitImageNode(LightImageNode image);
        void VisitParagraphNode(LightParagraphNode paragraph);
        void VisitSecondHeaderNode(LightSecondHeaderNode secondHeader);
    }
}