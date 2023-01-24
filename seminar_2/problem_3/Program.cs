/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */


int InputInt(string message)
{
    Console.Write(message + " > ");                // Вывод сообщения пользователю
    string inputValue = Console.ReadLine();        // Ввод строки пользователем
    int result = Convert.ToInt32(inputValue);      // Преобразование в целое введенной строки
    return result;                                 // возврат результата
}

int maxValue(int first, int second)
{

    if (first > second)
    {
        return first % second;
    }
    else
        return second % first;

}

void checkNums(int first, int second)
{

    if (first % second == 0 || second % first == 0)
    {
        Console.WriteLine("Числа кратны");
    }
    else
        Console.WriteLine($"Числа не кратны, остаток = {maxValue(first, second)}");

}

int firstNumber = InputInt("Введите первое число");
int secondNumber = InputInt("Введите второе число");
checkNums(firstNumber, secondNumber);