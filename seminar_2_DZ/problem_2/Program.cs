/* Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


int InputInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int TurningNumberTo3DigitNumber(int NewNumber)
{
    while (NewNumber >= 1000 || NewNumber <= -1000)
    {
        NewNumber /= 10;
    }
    return NewNumber;
}

int number = InputInt("Введите число > ");
if (number > 99 || number < -99)
{
    int thirdDigit = TurningNumberTo3DigitNumber(number) % 10;
    Console.WriteLine(thirdDigit);
}
else
    Console.WriteLine("Третьей цифры нет");


