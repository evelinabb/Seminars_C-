// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не используйте строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

bool CheckFiveDigitNumber(int number)
{
    if (number > 9999 && number < 100000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool FindFirstAndLastDigit(int number)
{
    int firstDigit = (number / 10000) % 10;
    int lastDigit = number % 10;
    if (firstDigit == lastDigit)
    {
        return true;
    }
    return false;
}

bool FindSecondAndPenultimateDigit(int number)
{
    int secondDigit = (number / 1000) % 10;
    int penultimateDigit = (number / 10) % 10;
    if (secondDigit == penultimateDigit)
    {
        return true;
    }
    return false;
}

int N = PromptInt("Введите число");
if (CheckFiveDigitNumber(N))
{
    if (FindFirstAndLastDigit(N))
    {
        if (FindSecondAndPenultimateDigit(N))
        {
            Console.WriteLine("Число является полиндромом");
        }
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }
}
else 
{
    Console.WriteLine("Число не пятизначное");
}