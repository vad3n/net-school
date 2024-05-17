using System.Text;

namespace Task8
{
    public class DiagonalMatrix<T> where T : struct
    {
        private T[] _elements;

        public int Size { get; }
        public event EventHandler<ElementArgs> ElementChanged;

        private void OnElementChange(ElementArgs args)
        {
            EventHandler<ElementArgs> handler = ElementChanged;

            if (handler != null)
            {
                handler(this, args);
            }
        }

        public DiagonalMatrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Argument must be not negative.");
            }

            _elements = new T[size];
            Size = size;
        }

        private bool IsIndexesInbound(int i, int j)
        {
            return i == j && i >= 0 && i < Size && j >= 0 && j < Size;
        }

        public T this[int i, int j]
        {
            get
            {
                if (!IsIndexesInbound(i, j))
                {
                    throw new IndexOutOfRangeException();
                }

                return _elements[i];
            }

            set
            {
                if (!IsIndexesInbound(i, j))
                {
                    throw new IndexOutOfRangeException();
                }

                if (!_elements[i].Equals(value))
                {
                    ElementArgs args = new ElementArgs(i, _elements[i], value);
                    OnElementChange(args);
                    _elements[i] = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("Diagonal Matrix:\n");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i != j)
                    {
                        result.Append($"{default(T)} ");
                    }

                    else
                    {
                        result.Append($"{this[i, j]} ");
                    }
                }

                result.Append('\n');
            }

            return result.ToString();
        }
    }
}
