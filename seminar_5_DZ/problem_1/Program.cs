// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] FillArray()
{
    int[] array = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1001);
    }
    return array;
}

void PrintArray(int[] array, string message)
{
    Console.Write(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CheckEven(int[] array)
{
    int countNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countNum++;
        }
    }
    return countNum;
}

int[] numsArray = FillArray();
PrintArray(numsArray, "Array: ");
Console.WriteLine("Even numbers: " + CheckEven(numsArray));
