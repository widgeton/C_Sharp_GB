// Задача 38
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max) + rnd.NextDouble();
    }

    return array;
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

double SubtractionMinFromMax(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
        if(min > array[i]) min = array[i];
    }

    return max - min;    
}

double[] arr = CreateArray(5, 1, 100);
PrintArray(arr);
double result = Math.Round(SubtractionMinFromMax(arr), 1, MidpointRounding.ToZero);
Console.WriteLine($"Разница максимального и минимального значения массива равна {result}");