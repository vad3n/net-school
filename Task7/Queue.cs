namespace Task7
{
    public class Queue<T> : IQueue<T>
    {
        private T[] _elements;
        private int _count;

        public Queue(int capacity)
        {
            _elements = new T[capacity];
            _count = 0;
        }

        public void Enqueue(T e)
        {
            if (_count == _elements.Length)
            {
                throw new Exception("Queue is full.");
            }

            _elements[_count++] = e;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                throw new Exception("Queue is empty.");
            }

            T result = _elements[0];

            for (int i = 0; i < _count; i++)
            {
                _elements[i] = _elements[i + 1];
            }

            _count--;
            return result;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public int GetCount()
        {
            return _count;
        }

        public int GetCapacity()
        {
            return _elements.Length;
        }

        public T[] GetElements()
        {
            return _elements;
        }
    }
}
