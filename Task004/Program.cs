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

    int num = num1;

    if(num < num2) num = num2;

    if(num < num3) num = num3;
    
    Console.WriteLine($"Число {num} максимальное из трех чисел.");
}

catch
{
    Console.WriteLine("Вы ввели некорректное знаение.");
}