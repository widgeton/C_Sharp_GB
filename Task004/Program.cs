// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
try
{
    Console.Write("Введите первое целое число: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Введите второе целое число: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.Write("Введите третье целое число: ");
    int num3 = int.Parse(Console.ReadLine());

    if (num1 > num2 && num1 > num3) Console.WriteLine($"Число {num1} максимальное из трех чисел.");
    else if (num2 > num1 && num2 > num3) Console.WriteLine($"Число {num2} максимальное из трех чисел.");
    else Console.WriteLine($"Число {num3} максимальное из трех чисел.");
}

catch
{
    Console.WriteLine("Вы ввели некорректное знаение.");
}