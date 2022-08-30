// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSnakeFillingMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    int num = 1;

    for (int forI = 0, forJ = 0; num <= row * col; forI++, forJ++)
    {
        int i = forI;
        int j = forJ;
        for (; j < col - 1 - forJ && num <= row * col; j++, num++)
            matrix[i, j] = num;

        for (; i < row - 1 - forI && num <= row * col; i++, num++)
            matrix[i, j] = num;

        for (; j > forJ && num <= row * col; j--, num++)
            matrix[i, j] = num;

        for (; i > forI && num <= row * col; i--, num++)
            matrix[i, j] = num;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
      else Console.Write($"{matrix[i, j], 3}");
    }
    Console.Write("]");
    Console.WriteLine();
  }
}

int[,] mtrx = CreateSnakeFillingMatrix(10, 5);
PrintMatrix(mtrx);