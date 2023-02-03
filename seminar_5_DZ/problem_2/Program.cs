// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray()
{
    int[] array = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 11);
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

int SumOddPositions(int[] array)
{
    int sumNum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sumNum += array[i];

    }
    return sumNum;
}

int[] numsArray = FillArray();
PrintArray(numsArray, "Array: ");
Console.WriteLine("Sum of numbers on odd positions: " + SumOddPositions(numsArray));
