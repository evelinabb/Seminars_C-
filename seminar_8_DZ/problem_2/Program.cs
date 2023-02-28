// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateArray(int x = 18, int y = 2)
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

int[] GetSumInRows(int[,] array)
{
    int[] massiv = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            massiv[i] += array[i, j];
        }
    }
    return massiv;
}

int ChooseMin(int[] massiv)
{
    int min = massiv[0];
    int minI = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] < min)
        {

            min = massiv[i];
            minI = i;
        }
    }
    return minI + 1;
}


void PrintMassiv(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        System.Console.Write(massiv[i] + " ");
    }
}


int[,] baseArray = CreateArray();
System.Console.WriteLine("Nas massiv:");
PrintArray(baseArray);
int[] sumsArray = GetSumInRows(baseArray);
System.Console.WriteLine("Summy elementov strok:");
PrintMassiv(sumsArray);
System.Console.WriteLine();
System.Console.Write("Stroka s naimensei summoi: ");
System.Console.WriteLine(ChooseMin(sumsArray));

