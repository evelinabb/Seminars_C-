// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int N = PromptInt("Введите число");
for (int i = 1; i <= N; i++)
{
    int result = i * i;
    Console.WriteLine(result);
}


// int PromptInt(string message)
// {
//     Console.Write($"{message} > ");
//     return int.Parse(Console.ReadLine());
// }

// int N = PromptInt("Введите число");

// int i = 1;
// while (i <= N)
// {
//     int result = i * i;
//     Console.WriteLine(result);
//     i += 1;
// }