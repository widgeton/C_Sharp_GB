// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

int[,] mtrx = CreateMatrix(3, 4, 1, 9);

Console.WriteLine("Задан массив: ");
PrintMatrix(mtrx);

Console.WriteLine();

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine()) - 1;

Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine()) - 1;

Console.WriteLine();

if(row <= mtrx.GetLength(0) && col <= mtrx.GetLength(1))
    Console.WriteLine($"Значение на позиции ({row + 1}; {col + 1}) равно {mtrx[row, col]}");
else Console.WriteLine("Такого элемента в массиве нет");