using Task5;

namespace Task5Tests
{
    [TestClass]
    public class DiagonalMatrixTests
    {
        [TestMethod]
        public void NonEmptyMatrixCreation()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1, 2, 3, 4, 5);

            Assert.AreEqual(5, matrix.Size);
        }

        [TestMethod]
        public void EmptyMatrixCreation()
        {
            DiagonalMatrix matrix = new DiagonalMatrix();

            Assert.AreEqual(0, matrix.Size);
        }

        [TestMethod]
        public void InboundMatrixIndexesAccess()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1, 2, 3, 4, 5);

            Assert.AreEqual(2, matrix[1, 1]);
        }

        [TestMethod]
        public void OutOfBoundMatrixIndexesAccess()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1, 2, 3, 4, 5);

            Assert.AreEqual(0, matrix[-1, 1]);
        }

        [TestMethod]
        public void InboundMatrixIndexesWrite()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1, 2, 3, 4, 5);
            matrix[1, 1] = 18;

            Assert.AreEqual(18, matrix[1, 1]);
        }

        [TestMethod]
        public void OutOfBoundMatrixIndexesWrite()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1, 2, 3, 4, 5);
            matrix[1, -1] = 20;

            Assert.AreEqual(2, matrix[1, 1]);
        }

        [TestMethod]
        public void MatrixTrack()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1, 2, 3, 4, 5, 6, 7);

            Assert.AreEqual(28, matrix.Track());
        }

        [TestMethod]
        public void MatrixEqualsTrue()
        {
            DiagonalMatrix matrix1 = new DiagonalMatrix(1, 2, 3, 4, 5, 6, 7);
            DiagonalMatrix matrix2 = new DiagonalMatrix(1, 2, 3, 4, 5, 6, 7);

            Assert.IsTrue(matrix1.Equals(matrix2));
        }

        [TestMethod]
        public void MatrixEqualsFalse()
        {
            DiagonalMatrix matrix1 = new DiagonalMatrix(1, 2, 3, 4, 5, 6, 7);
            DiagonalMatrix matrix2 = new DiagonalMatrix(1, 2, 3, 4, 5);

            Assert.IsFalse(matrix1.Equals(matrix2));
        }

        [TestMethod]
        public void MatrixToString()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1,2,3);

            Assert.AreEqual("Diagonal Matrix:\n1 0 0 \n0 2 0 \n0 0 3 \n", matrix.ToString());
        }
    }
}