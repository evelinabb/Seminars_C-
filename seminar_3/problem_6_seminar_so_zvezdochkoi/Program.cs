// Задача 6*: Напишите программу, которая выводит первые 2 заданные элемента следующей последовательности: 
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5


int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    collection[index] = 1;
    while (index < length)
    {
        while (collection[index] < collection[index] + 1)
        {
            System.Console.Write(collection[index] + ", ");
        }
        index++;
        collection[index]++;
    }
}

int number = PromptInt("Введите число");
int[] array = new int[number];

PrintArray(array);





