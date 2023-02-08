// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreateArray(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
    return array;
}

int[] FillArray(int[] array, string msg)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(msg);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array, string msg)
{
    Console.Write(msg);
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int PositiveNumCount(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0)
        {
            count++;
        }
    }
    return count;
}

int[] userArray = CreateArray("Vvedite dlinu massiva > ");
FillArray(userArray, "Vvedite cislo > ");
PrintArray(userArray, "Vash massiv: ");
Console.WriteLine($"Kolicestvo polozitelnych cisel v massive: {PositiveNumCount(userArray)}");



