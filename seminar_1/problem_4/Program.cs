//Напишите программу вычисления модуля числа. 2 -> 2 -3 -> 3 -7 -> 7

Console.Write("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = -number;
}
Console.WriteLine(number);