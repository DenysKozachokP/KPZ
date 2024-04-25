using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask1
{
    public class InternetHandler : Handler
    {
        public override void HandlerIssue()
        {
            Console.WriteLine("Перенаправленно на оператора з вирішення проблем з інтернетом");
        }
    }
}
