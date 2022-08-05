// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

try
{
    Console.Write("Введите первое целое число: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Введите второе целое число: ");
    int num2 = int.Parse(Console.ReadLine());

    if (num1 > num2) Console.WriteLine($"Число {num1} больше {num2}");
    else if (num1 < num2) Console.WriteLine($"Число {num2} больше {num1}");
    else Console.WriteLine("Числа равны.");
}

catch
{
    Console.WriteLine("Вы ввели неккоректное значение.");
}