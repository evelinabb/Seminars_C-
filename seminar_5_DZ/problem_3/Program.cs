// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//что-то не получилось создать массив из вещественных чисел((

double[] FillArray()
{
    double[] array = new double[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 11);
    }
    return array;
}

void PrintArray(double[] array, string message)
{
    Console.Write(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MaxNumber(double[] array)
{
    double maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}

double MinNumber(double[] array)
{
    double minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {

        if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    return minNum;
}


double[] numsArray = FillArray();
PrintArray(numsArray, "Array: ");
double diff = MaxNumber(numsArray) - MinNumber(numsArray);
Console.WriteLine("Difference between max and min: " + diff);
