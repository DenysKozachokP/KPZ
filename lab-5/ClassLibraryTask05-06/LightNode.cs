namespace ClassLibraryTask05_06
{
    public abstract class LightNode
    {
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }
        public event Action<string> NodeEvent;

        public void InvokeNodeEvent(string eventName)
        {
            NodeEvent?.Invoke(eventName);
        }

        public void OnCreated()
        {
            InvokeNodeEvent($"Node created: {GetType().Name}");
        }

        public void OnInserted()
        {
            InvokeNodeEvent($"Node inserted: {GetType().Name}");
        }

        public void OnRemoved()
        {
            InvokeNodeEvent($"Node removed: {GetType().Name}");
        }

        public void OnStylesApplied()
        {
            InvokeNodeEvent($"Styles applied to node: {GetType().Name}");
        }

        public void OnClassListApplied()
        {
            InvokeNodeEvent($"Classes applied to node: {GetType().Name}");
        }

        public void OnTextRendered()
        {
            InvokeNodeEvent($"Text rendered for node: {GetType().Name}");
        }
    }
}
