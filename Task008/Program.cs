// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

try
{
    Console.Write("Введите натуральное число: ");
    int num = int.Parse(Console.ReadLine());

    if (num <= 0) throw new Exception();

    if (num == 1) Console.WriteLine("Четные числа отсутствуют.");
    else
    {
        Console.Write($"Четные числа от 1 до {num}: ");

        for (int i = 2; i <= num; i += 2) Console.Write($"{i} ");

        Console.WriteLine();
    }
}

catch
{
    Console.WriteLine("Вы ввели некорректное значение.");
}