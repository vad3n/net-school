using Task10;

SparseMatrix matrix1 = new SparseMatrix(5, 5);
matrix1[0, 0] = 200;
matrix1[0, 1] = 300;
matrix1[1, 0] = 400;
matrix1[2, 2] = 500;
matrix1[3, 4] = 600;
matrix1[4, 4] = 700;
Console.WriteLine(matrix1);

foreach (var item in matrix1.GetNonzeroElements())
{
    Console.WriteLine(item.Item1 + " " + item.Item2 + " " + item.Item3);
}

foreach (var item in matrix1)
{
    Console.WriteLine(item);
}

SparseMatrix matrix2 = new SparseMatrix(2, 3);
matrix2[0, 0] = 247;
matrix2[1, 1] = 478;
matrix2[1, 2] = 696;
Console.WriteLine(matrix2);

foreach (var item in matrix2)
{
    Console.WriteLine(item);
}

SparseMatrix matrix3 = new SparseMatrix(4, 3);
matrix3[0, 0] = 247;
matrix3[1, 1] = 478;
matrix3[1, 2] = 696;
matrix3[2, 1] = 748;
matrix3[3, 2] = 829;
Console.WriteLine(matrix3);

foreach (var item in matrix3)
{
    Console.WriteLine(item);
}

SparseMatrix matrix4 = new SparseMatrix(4, 3);
matrix4[0, 0] = 1;
matrix4[0, 1] = 5;
matrix4[0, 2] = 9;
matrix4[1, 0] = 2;
matrix4[1, 1] = 6;
matrix4[1, 2] = 10;
matrix4[2, 0] = 3;
matrix4[2, 1] = 7;
matrix4[2, 2] = 11;
matrix4[3, 0] = 4;
matrix4[3, 1] = 8;
matrix4[3, 2] = 12;
Console.WriteLine(matrix4);

foreach (var item in matrix4.GetNonzeroElements())
{
    Console.WriteLine(item);
}
