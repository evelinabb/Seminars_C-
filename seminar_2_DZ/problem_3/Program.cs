/* Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckWeekDay(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Выходной!");
    }
    else
        Console.WriteLine("Не выходной(("); ;
}

int number = InputInt("Введите число > ");
CheckWeekDay(number);
