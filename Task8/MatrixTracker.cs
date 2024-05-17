namespace Task8
{
    public class MatrixTracker<T> where T : struct
    {
        private int _index;
        private T _oldValue;
        private DiagonalMatrix<T> _matrix;

        private void MatrixEventHandler(object sender, ElementArgs args)
        {
            _index = args.ElementIndex;
            _oldValue = (T)args.ElementOldValue;
        }

        public MatrixTracker(DiagonalMatrix<T> matrix)
        {
            _matrix = matrix;
            matrix.ElementChanged += MatrixEventHandler;
        }

        public void Undo()
        {
            _matrix[_index, _index] = _oldValue;
        }
    }
}
