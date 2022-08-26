// Задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int row, int col, int min, int max)
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
        Console.WriteLine("]");
    }
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        double value = Math.Round(array[i], 1, MidpointRounding.ToZero);
        if(i < array.Length - 1) Console.Write(value + ", ");
        else Console.Write(value);
    }
    Console.WriteLine("]");
}

double[] FindAverageEachColumns(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }

        average[i] = sum / matrix.GetLength(0);
    }

    return average;
}

int[,] mtrx = CreateMatrix(3, 4, 1, 9);

Console.WriteLine("Задан массив: ");
PrintMatrix(mtrx);

Console.WriteLine();

double[] avrg = FindAverageEachColumns(mtrx);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(avrg);