/* Напишите программу, которая выводит случайное число, которое введет пользователь и показывает наибольшую цифру числа.
*/

int InputInt(string message)
{
    Console.Write(message + " > ");                // Вывод сообщения пользователю
    string inputValue = Console.ReadLine();        // Ввод строки пользователем
    int result = Convert.ToInt32(inputValue);      // Преобразование в целое введенной строки
    return result;                                 // возврат результата
}


int Max(int num)
{
    int max = 0;
    while (num > 0)
    {
        int temp = num % 10;
        if (temp > max)
        {
            max = temp;
        }
        num = num / 10;
    }
    return max;
}

int number = InputInt("Введите число");
int maxNumber = Max(number);
Console.WriteLine($"Максимальная цифра в числе {number} : {maxNumber}");

