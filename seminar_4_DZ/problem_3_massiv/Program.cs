// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Сделать через функции
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}


int[] CreateArray(int collection, int min, int max)
{
    int[] array = new int[collection];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;

}

void PrintArray(int[] massiv)
{
    Console.Write("[ ");
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write(massiv[i]);
        if (i < massiv.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}


int size = PromptInt("Введите размер массива");
int minNumber = PromptInt("Введите минимальное значение");
int maxNumber = PromptInt("Введите максимальное значение");
int[] massiv = CreateArray(size, minNumber, maxNumber);
Console.Write("Ваш массив: ");
PrintArray(massiv);
