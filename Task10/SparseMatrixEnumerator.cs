using System.Collections;

namespace Task10
{
    public class SparseMatrixEnumerator : IEnumerator<long>
    {
        private SparseMatrix _matrix;
        private int _index;
        private int _size;

        public long Current => _matrix[_index / _matrix.Columns, _index % _matrix.Columns];

        object IEnumerator.Current => Current;

        public SparseMatrixEnumerator(SparseMatrix matrix)
        {
            _matrix = matrix;
            _index = -1;
            _size = _matrix.Rows * _matrix.Columns;
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            _index++;
            return _index < _size;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
