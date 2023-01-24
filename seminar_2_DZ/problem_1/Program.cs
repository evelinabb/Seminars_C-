/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. 
456 -> 5
782 -> 8
918 -> 1 */

int InputInt(string message)
{
    Console.Write("Введите число > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumberRank3(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    else
        Console.WriteLine("Число не трехзначное.");
    return false;
}

int number = InputInt("Введите число");

if (ValidateNumberRank3(number))
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {number} : {secondDigit}");
}