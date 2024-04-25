using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask3_4
{
    public class LightHTML
    {
        public LightNode Root { get; set; }
        public Dictionary<string, List<Action>> EventListeners { get; set; }

        public LightHTML(LightNode root)
        {
            Root = root;
            EventListeners = new Dictionary<string, List<Action>>();
        }

        public string GetHtml()
        {
            return Root.OuterHtml;
        }

        public void AddEventListener(string eventName, Action action)
        {
            if (!EventListeners.ContainsKey(eventName))
            {
                EventListeners[eventName] = new List<Action>();
            }
            EventListeners[eventName].Add(action);
        }

        public void TriggerEvent(string eventName)
        {
            if (EventListeners.ContainsKey(eventName))
            {
                foreach (var action in EventListeners[eventName])
                {
                    action.Invoke();
                }
            }
        }
    }
}
