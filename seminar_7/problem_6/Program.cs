// Задача 5: Задайте двумерный массив. Найдите максимальный элемент массива 
// и среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Максимальный элемент массива 9
// Среднее арифметическое 4.25


int[,] CreateArray(int l = 4, int c = 4)
{
    int[,] array = new int[l, c];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    Console.WriteLine();
}

int FindMax(int[,] array)
{
    int max = array[0,0];
    foreach (int item in array)
    {
        if (item> max)
        {
            max = item;
        }
    }

    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         if (array[i,j] > max)
    //         {
    //             max = array[i,j];
    //         }
    //     }
    // }
    return max;
}

double FindAverage(int[,] array)
{
    double sum = 0;
    // int amount = array.Length //beret kolvo vseh el-tov
    foreach (int item in array)
    {
        sum+=item;
    }
    return sum/array.Length;
}

int [,] baseArray = CreateArray();
PrintArray(baseArray);
int maxResult = FindMax(baseArray);
Console.WriteLine($"Max result : {maxResult}");
double averageResult = FindAverage(baseArray);
Console.WriteLine($"Average result : {averageResult}");
