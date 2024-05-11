namespace Task5
{
    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix Addition(this DiagonalMatrix first, DiagonalMatrix second)
        {
            int size = Math.Max(first.Size, second.Size);
            int[] result = new int[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = (i < first.Size ? first[i, i] : 0) + (i < second.Size ? second[i, i] : 0);
            }

            return new DiagonalMatrix(result);
        }
    }
}
