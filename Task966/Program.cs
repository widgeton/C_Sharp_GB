// Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumInRange(int a, int b)
{
    int sum = default;
    if(a < b)
    {
        sum = a + SumInRange(a + 1, b);
    }
    if(a > b)
    {
        sum = a + SumInRange(a - 1, b);
    }
    if(a == b)
    {
        sum += a;
    }
    return sum;
}

System.Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Сумма чисел от {n} до {m} = {SumInRange(n, m)}");