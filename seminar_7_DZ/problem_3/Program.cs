// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateNumbersArray()
{
    Random rnd = new Random();
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindColumnMean(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        mean = sum / array.GetLength(0);
        Console.Write($"{mean:F2}; ");
    }
}

int[,] baseArray = CreateNumbersArray();
Console.WriteLine("Massiv: ");
PrintArray(baseArray);
Console.WriteLine("Srednee arifmeticeskoe v kazdom stolbce: ");
FindColumnMean(baseArray);




