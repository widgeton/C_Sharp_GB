// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateIntMatrix(int row, int col, int min, int max)
{
  int[,] matrix = new int[row, col];
  var rnd = new Random();

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
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

void SortValuesInRowsOfMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
      int index = j;

      for (int k = j + 1; k < matrix.GetLength(1); k++)
        if (matrix[i, index] < matrix[i, k]) index = k;

      int temp = matrix[i, index];
      matrix[i, index] = matrix[i, j];
      matrix[i, j] = temp;
    }
  }
}

int[,] mtrx = CreateIntMatrix(3, 4, 1, 9);
PrintMatrix(mtrx);

Console.WriteLine();

SortValuesInRowsOfMatrix(mtrx);
PrintMatrix(mtrx);