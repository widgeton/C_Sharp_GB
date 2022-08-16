// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// /2, 4 -> 16

int GetDegree(int num, int degree)
{
    int temp = num;
    for(int i = 1; i < degree; i++)
    {
        num *= temp;
    }

    return num;
}

Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите степень числа: ");
int d = int.Parse(Console.ReadLine());

if(d > 0)
{
    int result = GetDegree(n, d);
    Console.WriteLine($"Число {n} в степени {d} равно {result}");
}
else Console.WriteLine($"Вы ввели некорректное значение.\nСтепень должна быть указана в виде натурального числа.");