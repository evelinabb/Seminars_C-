/* Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22 */

Console.Write("Введите первое число > ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число > ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число > ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int MaxNumber = FirstNumber;

if (SecondNumber > MaxNumber)
{
    MaxNumber = SecondNumber;
}

if (ThirdNumber > MaxNumber)
{
    MaxNumber = ThirdNumber;
}

Console.WriteLine(MaxNumber);
