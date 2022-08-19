// Задача 36
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int SumElementsWithOddIndex (int[] array)
{
    int sum = default;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

int[] arr = CreateArray(4, -10, 100);
PrintArray(arr);
int result = SumElementsWithOddIndex(arr);
Console.WriteLine($"Сумма элементов с нечетными индексами равна {result}");