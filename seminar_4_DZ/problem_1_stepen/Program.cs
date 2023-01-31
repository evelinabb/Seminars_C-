// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int MathPow(int number1, int number2)
{
    int powerNumber = 1;
    int i = 0;
    while (i < number2)
    {
        powerNumber *= number1;
        i++;
    }
    return powerNumber;
}

int a = PromptInt("Введите число А");
int b = PromptInt("Введите число В");
int powNum = MathPow(a, b);
System.Console.WriteLine(powNum);