// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateArray(int x = 2, int y = 2)
{
    int[,] array = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
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
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] GetMatricesMultiplication(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] massiv = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int x = 0; x < massiv.GetLength(0); x++)
            {
                massiv[i, j] += arrayFirst[i, x] * arraySecond[x, j];
            }
        }
    }
    return massiv;
}

int[,] firstArray = CreateArray();
System.Console.WriteLine("Pervii massiv:");
PrintArray(firstArray);
int[,] secondArray = CreateArray();
System.Console.WriteLine("Vtoroi massiv:");
PrintArray(secondArray);
System.Console.WriteLine();
int[,] resultArray = GetMatricesMultiplication(firstArray, secondArray);
PrintArray(resultArray);



