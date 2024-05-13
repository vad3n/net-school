namespace Task8
{
    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix<T> Addition<T>(this DiagonalMatrix<T> first, DiagonalMatrix<T> second, Func<T, T, T> func) where T : struct
        {
            if (first == null || second == null || func == null)
            {
                throw new ArgumentNullException();
            }

            int size = Math.Max(first.Size, second.Size);
            DiagonalMatrix<T> result = new DiagonalMatrix<T>(size);

            for (int i = 0; i < size; i++)
            {
                result[i, i] = func(i < first.Size ? first[i, i] : default, i < second.Size ? second[i, i] : default);
            }

            return result;
        }
    }
}
