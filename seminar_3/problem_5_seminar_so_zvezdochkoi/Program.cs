// Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел 
// из 10 элементов в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.

//этого задания не было в ДЗ, но оно было со звездочкой на семинаре и по-моему решения показано не было (или я что-то пропустила:))
//и мне стало интересно 

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        System.Console.Write(collection[index] + ", ");
        index++;

    }
}

int[] array = new int[10];
PrintArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 5)
    {
        count++;
    }
}

System.Console.WriteLine($"\nБыло сгенерировано {count} чисел больше пяти");