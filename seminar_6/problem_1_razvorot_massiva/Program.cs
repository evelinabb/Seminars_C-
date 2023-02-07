// Напишите программу. которая перевернет одномерный массив

int InputInt(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int len, int minValue = 0, int maxValue = 10)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}; ");
    }
    System.Console.WriteLine();
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        Swap1(array, i, array.Length - 1 - i);
    }
    return array;
}

void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

void Swap1(int[] array, int i, int j)                     //KORTEJ
{
    (array[i], array[j]) = (array[j], array[i]);
}

int len = InputInt("Vvedite dlinu massiva");
int[] array = GenerateArray(len);
PrintArray(array);
PrintArray(Reverse(array));



