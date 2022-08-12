// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x для первой точки: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату y для первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату z для первой точки: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите координату x для второй точки: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату y для второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату z для второй точки: ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine();

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
result = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками равно {result}");