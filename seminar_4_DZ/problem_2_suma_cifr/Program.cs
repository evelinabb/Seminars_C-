// Задача 2: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int Sum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int number = PromptInt("Введите число А");
int suma = Sum(number);
Console.WriteLine(suma);
