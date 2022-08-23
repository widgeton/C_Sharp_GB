// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int[] StringArrayToInt(string[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(array[i]);
    }
    return arr;
}

int PositiveNumbersInArray(int[] array)
{
    int count = 0;
    foreach (var i in array)
    {
        if(i > 0) count++;
    }
    return count;
}

Console.Write("Введите ряд целых чисел через пробел: ");
string[] numbers = Console.ReadLine().Split();
int[] nums = StringArrayToInt(numbers);

Console.WriteLine($"Пользователь ввел {PositiveNumbersInArray(nums)} чисел больше нуля");