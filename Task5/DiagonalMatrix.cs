using System.Text;

namespace Task5
{
    public class DiagonalMatrix
    {
        private int[] _elements;

        public int Size { get; }

        public DiagonalMatrix(params int[] elements)
        {
            if (elements == null)
            {
                _elements = new int[0];
                Size = 0;
            }

            else
            {
                _elements = elements;
                Size = elements.Length;
            }
        }

        private bool IsIndexesInbound(int i, int j)
        {
            return i == j && i >= 0 && i < Size && j >= 0 && j < Size;
        }

        public int this[int i, int j]
        {
            get
            {
                if (!IsIndexesInbound(i, j))
                {
                    return 0;
                }

                return _elements[i];
            }

            set
            {
                if (!IsIndexesInbound(i, j))
                {
                    return;
                }

                _elements[i] = value;
            }
        }

        public int Track()
        {
            int sum = 0;

            foreach (var element in _elements)
            {
                sum += element;
            }

            return sum;
        }

        public override bool Equals(object? obj)
        {
            if (obj is DiagonalMatrix other && this.Size == other.Size)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (_elements[i] != other[i, i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int result = 0;

            foreach (var element in _elements)
            {
                result += result * 15 + element;
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("Diagonal Matrix:\n");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    result.Append($"{this[i, j]} ");
                }

                result.Append('\n');
            }

            return result.ToString();
        }
    }
}
