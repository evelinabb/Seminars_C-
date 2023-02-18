// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 - > 1


int Prompt(string msg)
{
    Console.Write($"{msg} -> ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateNumbersArray()
{
    Random rnd = new Random();
    int[,] array = new int[4, 4];
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
}

void FindNumber(int[,] array, int m, int n)
{
    if (m <= array.GetLength(0) && n <= array.GetLength(1))
    {
        int num = array[m - 1, n - 1];
        Console.WriteLine($"Iskomoe cislo: {num}");
    }
    else
        Console.WriteLine("Takogo cisla v massive net");

}

int[,] baseArray = CreateNumbersArray();
PrintArray(baseArray);
int numberM = Prompt("Vvedite stroku");
int numberN = Prompt("Vvedite stolbec");
FindNumber(baseArray, numberM, numberN);