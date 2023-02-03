// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] FillArray()
{
    int[] array = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 11);
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

int MaxNumber(int[] array)
{
    int maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}

int MinNumber(int[] array)
{
    int minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {

        if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    return minNum;
}


int[] numsArray = FillArray();
PrintArray(numsArray, "Array: ");
int diff = MaxNumber(numsArray) - MinNumber(numsArray);
Console.WriteLine("Difference between max and min: " + diff);
