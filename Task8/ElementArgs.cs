namespace Task8
{
    public class ElementArgs : EventArgs
    {
        public int ElementIndex { get; }
        public object ElementOldValue { get; }
        public object ElementNewValue { get; }

        public ElementArgs(int index, object oldValue, object newValue)
        {
            ElementIndex = index;
            ElementOldValue = oldValue;
            ElementNewValue = newValue;
        }
    }
}
