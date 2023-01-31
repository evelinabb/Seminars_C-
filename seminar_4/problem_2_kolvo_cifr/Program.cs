// Задача 1: Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 84973 -> 5

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int CountRank(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}


int num = PromptInt("Vvedite cislo");
System.Console.WriteLine(CountRank(num));