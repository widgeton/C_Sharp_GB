// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumFigures(int num)
{
    int sum = default;
    
    if(num < 0) num *= -1;    
    while(num > 0)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine());

int result = SumFigures(n);
Console.WriteLine($"Сумма цифр в числе {n} равно {result}");