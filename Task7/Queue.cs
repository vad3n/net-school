namespace Task7
{
    public class Queue<T> : IQueue<T> where T : struct
    {
        private T[] _elements;
        private int _count;
        private int _head = 0;
        private int _tail = 0;

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

            _elements[_tail] = e;
            _tail++;

            if (_tail == _elements.Length)
            {
                _tail = 0;
            }

            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                throw new Exception("Queue is empty.");
            }

            T result = _elements[_head];
            _head++;

            if (_head == _elements.Length)
            {
                _head = 0;
            }

            _count--;

            return result;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public object Clone()
        {
            Queue<T> result = new Queue<T>(_elements.Length);

            if (_tail > _head)
            {
                for (int i = _head; i < _tail; i++)
                {
                    result.Enqueue(_elements[i]);
                }
            }

            else
            {
                for (int i = _head; i < _elements.Length; i++)
                {
                    result.Enqueue(_elements[i]);
                }

                for (int i = 0; i < _tail; i++)
                {
                    result.Enqueue(_elements[i]);
                }
            }

            return result;
        }
    }
}
