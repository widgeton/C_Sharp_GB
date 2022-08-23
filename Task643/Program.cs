// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x(k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

Console.Write("Введите значение b для первой прямой: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Введите значение k для первой прямой: ");
int k1 = int.Parse(Console.ReadLine());

Console.Write("Введите значение b для второй прямой: ");
int b2 = int.Parse(Console.ReadLine());

Console.Write("Введите значение k для второй прямой: ");
int k2 = int.Parse(Console.ReadLine());

double[] FindCrossingPoint(int a1, int c1, int a2, int c2)
{
    double[] xy = new double[2];

    xy[0] = (double)(a2 - a1) / (c1 - c2);
    xy[1] = c1 * xy[0] + a1;

    return xy;
}

double[] result = FindCrossingPoint(b1, k1, b2, k2);
if(result[0] == -0 || result[1] == -0) Console.WriteLine("Прямые параллельны");
else Console.WriteLine($"({result[0]}; {result[1]})");