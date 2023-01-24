// Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает последнюю цифру этого числа.

// Это функция, которую можно вызвать. Ввод числа с консоли

int InputInt (string message)
{
    Console.Write(message + " > ");                // Вывод сообщения пользователю
    string inputValue = Console.ReadLine();        // Ввод строки пользователем
    int result = Convert.ToInt32(inputValue);      // Преобразование в целое введенной строки
    return result;                                 // возврат результата
}

// Проверка на 3-хзначность
bool ValidateNumberRank3 (int number)
{
    if (number > 99 && number < 1000)               // Проверка на трехзначность
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное.");  // Пользователь ввел не трехзначное число
    return false;
}

int number = InputInt("Ввевите трехзначное число"); // Вызов функции ввода

if (ValidateNumberRank3(number))                    // Проверяем на трехзначность
{
    int lastRank = number % 10;                      // последняя цифра
    System.Console.WriteLine($"Последняя цифра числа {number} равна {lastRank}");
}