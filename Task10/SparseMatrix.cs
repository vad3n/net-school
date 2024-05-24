using System.Collections;
using System.Text;

namespace Task10
{
    public class SparseMatrix : IEnumerable<long>
    {
        private IDictionary<Tuple<int, int>, long> _elements = new Dictionary<Tuple<int, int>, long>();
        private int _rows;
        private int _columns;

        public int Rows => _rows;
        public int Columns => _columns;

        public SparseMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Dimensions must be greater than zero.");
            }

            _rows = rows;
            _columns = columns;
        }

        private bool IsIndexesInbound(int i, int j)
        {
            return i >= 0 && i < _rows && j >= 0 && j < _columns;
        }

        public long this[int i, int j]
        {
            get
            {
                if (!IsIndexesInbound(i, j))
                {
                    throw new IndexOutOfRangeException();
                }

                Tuple<int, int> key = new Tuple<int, int>(i, j);

                return _elements.ContainsKey(key) ? _elements[key] : 0;
            }

            set
            {
                if (!IsIndexesInbound(i, j))
                {
                    throw new IndexOutOfRangeException();
                }

                Tuple<int, int> key = new Tuple<int, int>(i, j);

                if (_elements.ContainsKey(key))
                {
                    _elements[key] = value;
                }

                else
                {
                    _elements.Add(key, value);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("Diagonal Matrix:\n");

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    result.Append($"{this[i, j]} ");
                }

                result.Append('\n');
            }

            return result.ToString();
        }

        public IEnumerator<long> GetEnumerator()
        {
            return new SparseMatrixEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<(int, int, long)> GetNonzeroElements()
        {
            return _elements.OrderBy(e => e.Key.Item2).ThenBy(e => e.Key.Item1).Select(e => (e.Key.Item1, e.Key.Item2, e.Value));
        }

        public int GetCount(long x)
        {
            if (x == 0)
            {
                return _rows * _columns - _elements.Count;
            }

            return _elements.Values.Where(v => v == x).Count();
        }
    }
}
