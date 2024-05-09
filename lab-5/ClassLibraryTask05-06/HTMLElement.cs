using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibraryTask05_06
{
    class HtmlElement
    {
        private ElementState _state;
        private readonly string _element;

        public HtmlElement(string element)
        {
            _element = element;
            SetInactiveState();
        }

        private void SetInactiveState()
        {
            _state = new InactiveState(_element);
            _state.Handle();
        }

        private void SetActiveState()
        {
            _state = new ActiveState(_element);
            _state.Handle();
        }

        public void Activate()
        {
            SetActiveState();
        }

        public void Deactivate()
        {
            SetInactiveState();
        }
    }

}
