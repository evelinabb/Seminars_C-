// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int N = PromptInt("Введите число");
for (int i = 1; i <= N; i++)
{
    int result = i * i * i;
    Console.WriteLine(result);
}