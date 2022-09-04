// Задача 56:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindRowWithMinSumElements(int[,] matrix)
{
  int row = default;
  int sumLast = 0;

  for (int j = 0; j < matrix.GetLength(1); j++)
    sumLast += matrix[0, j];

  for (int i = 1; i < matrix.GetLength(0); i++)
  {
    int sumNext = default;

    for (int j = 0; j < matrix.GetLength(1); j++)
      sumNext += matrix[i, j];

    if (sumNext < sumLast)
    {
      sumLast = sumNext;
      row = i;
    }
  }

  return row;
}

int[,] mtrx = CreateIntMatrix(4, 4, 1, 5);

PrintMatrix(mtrx);

Console.WriteLine();

int r = FindRowWithMinSumElements(mtrx);
Console.WriteLine($"Строка №{r + 1}");