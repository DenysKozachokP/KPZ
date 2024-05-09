using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibraryTask05_06
{
    abstract class ElementState
    {
        protected readonly string _element;

        public ElementState(string element)
        {
            _element = element;
        }

        public abstract void Handle();
    }
}