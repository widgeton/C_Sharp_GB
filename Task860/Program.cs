// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateIntUniqueValueCube(int row, int col, int depth, int min, int max)
{
    int[] array = new int[row * col * depth];
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
        for (int j = i - 1; j >= 0; j--)
        {
            if (array[i] == array[j])
            {
                i--;
                break;
            }
        }
    }

    int[,,] cube = new int[row, col, depth];
    int index = default;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                cube[i, j, k] = array[index];
                index++;
            }
        }
    }

    return cube;
}

void PrintCube(int[,,] cube)
{
  for (int i = 0; i < cube.GetLength(2); i++)
  {
    for (int j = 0; j < cube.GetLength(0); j++)
    {
      for (int k = 0; k < cube.GetLength(1); k++)
      {
        Console.Write($"{cube[j, k, i]}({j},{k},{i}) ");
      }
      Console.WriteLine();
    }
  }
}

int[,,] c = CreateIntUniqueValueCube(2, 2, 2, 10, 99);
PrintCube(c);