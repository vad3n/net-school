using Task5;

DiagonalMatrix matrix1 = new DiagonalMatrix(1, 2, 3, 4);
Console.WriteLine(matrix1);
DiagonalMatrix matrix2 = new DiagonalMatrix(1, 2, 3, 4, 5, 6, 7);
Console.WriteLine(matrix2);
Console.WriteLine(matrix1.Addition(matrix2));