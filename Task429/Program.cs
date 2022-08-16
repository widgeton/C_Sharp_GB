// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int s)
{
    int[] arr = new int[s];
    var rnd = new Random();
    for(int i = 0; i < s; i++)
    {
        arr[i] = rnd.Next(100);
    }

    return arr;
}

void ShowArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int size = 8;
int[] a = FillArray(size);
ShowArray(a);