using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask05_06
{
    public interface INodeEvents
    {
        event Action<string> NodeEvent;
        void InvokeNodeEvent(string eventName);
    }
}