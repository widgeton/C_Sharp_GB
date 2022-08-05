// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

try
{
    Console.Write("Введите целое число: ");
    int num = int.Parse(Console.ReadLine());

    if (num == 0) throw new Exception();

    if (num % 2 == 0) Console.WriteLine($"Число {num} четное.");
    else Console.WriteLine($"Число {num} нечетное.");
}

catch
{
    Console.WriteLine("Вы ввели некорректное значение.");
}