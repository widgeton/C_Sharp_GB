// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrix(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    var rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max) + rnd.NextDouble();
        }
    }

    return matrix;
}

void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double value = Math.Round(matrix[i, j], 1, MidpointRounding.ToZero);
            if (j < matrix.GetLength(1) - 1) Console.Write($"{value, 4} ");
            else Console.Write($"{value, 4}");
        }
        Console.WriteLine("]");
    }
}

double[,] mtrx = CreateMatrix(3, 4, 0, 10);
PrintMatrix(mtrx);
