using Task8;

DiagonalMatrix<int> matrix1 = new DiagonalMatrix<int>(3);
MatrixTracker<int> tracker1 = new MatrixTracker<int>(matrix1);
matrix1[0, 0] = 1;
matrix1[1, 1] = 2;
matrix1[2, 2] = 3;
Console.WriteLine(matrix1);

DiagonalMatrix<int> matrix2 = new DiagonalMatrix<int>(5);
matrix2[0, 0] = 4;
matrix2[1, 1] = 5;
matrix2[2, 2] = 6;
matrix2[3, 3] = 7;
matrix2[4, 4] = 8;
Console.WriteLine(matrix2);

DiagonalMatrix<double> matrix3 = new DiagonalMatrix<double>(5);
matrix3[0, 0] = 1.2;
matrix3[1, 1] = 1.8;
matrix3[2, 2] = 4.5;
Console.WriteLine(matrix3);
MatrixTracker<double> tracker2 = new MatrixTracker<double>(matrix3);
matrix3[3, 3] = 2.95;
matrix3[4, 4] = 3.64;
Console.WriteLine(matrix3);
matrix3[4, 4] = 5.18;
Console.WriteLine(matrix3);
tracker2.Undo();
Console.WriteLine(matrix3);

DiagonalMatrix<int> matrix4 = matrix1.Addition(matrix2, (a, b) => a + b);
Console.WriteLine(matrix4);