﻿// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void ShowNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    // Console.Write($"{number} ");  // c конца выдаст значения
    ShowNumbers(number-1);
    Console.Write($"{number} ");

}

int n = Prompt("Vvedite cislo: ");
ShowNumbers(n);
