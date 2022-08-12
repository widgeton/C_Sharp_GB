// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 10000 && num < 100000)
{
    int end, beginning;
    int digit = 1;
    bool k = true;

    for (int i = num; i != i % 10; i /= 10)
        digit *= 10;

    if (digit == 1)
    {
        Console.WriteLine($"Число {num} - одноразрядное и не может являться палиндромом!");
        k = false;
    }

    for (int i = 1; i < digit / i; i *= 10)
    {
        end = num / i % 10;
        beginning = num / (digit / i) % 10;

        if (end != beginning)
        {
            Console.WriteLine($"Число {num} НЕ является палиндромом");
            k = false;
            break;
        }
    }

    if (k) Console.WriteLine($"Число {num} является палиндромом");
}

else Console.WriteLine("Введено некорректное значение");