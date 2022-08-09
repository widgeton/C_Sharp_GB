//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int numPositive = num > 0 ? num : -num;
int digit = numPositive;

while(digit > 1000) digit /= 10;

digit %= 10;

if(numPositive < 100) Console.WriteLine($"Третьей цифры у числа {num} нет");
else Console.WriteLine($"Цифра {digit} - третья цифра числа {num}");