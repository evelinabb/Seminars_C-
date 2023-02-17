// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string msg)
{
    Console.Write($"{msg} -> ");
    return int.Parse(Console.ReadLine());
}

void EvenNumbers(int n, int m)
{
    n += n % 2;
    if (n > m)
    {
        return;
    }
    Console.Write($"{n}; ");
    EvenNumbers(n + 2, m);
}

int numberM = Prompt("Vvedite cislo M");
int numberN = Prompt("Vvedite cislo N");
EvenNumbers(numberM, numberN);


