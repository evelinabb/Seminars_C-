﻿// Задача 2: Задайте значения M и N. Напишите программу, которая 
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}


void ShowNumbers(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    System.Console.Write($"{start} ");
    ShowNumbers(start + 1, finish);
    
}

int number1 = Prompt("Vvedite cislo M -> ");
int number2 = Prompt("Vvedite cislo N -> ");

ShowNumbers(number1, number2);