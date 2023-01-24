/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
(усложняем: на вход принимаем три числа, и проверяем, кратно ли первое двум вторым)
14 -> нет 
46 -> нет 
161 -> да */

int InputInt(string message)
{
    Console.Write($"Введите {message} число > ");                // Вывод сообщения пользователю
    string inputValue = Console.ReadLine();        // Ввод строки пользователем
    int result = Convert.ToInt32(inputValue);      // Преобразование в целое введенной строки
    return result;                                 // возврат результата
}


bool CheckNumber(int first, int second, int third)
{
    if (first % second == 0 && first % third == 0)
    {
        return true;
    }
    else return false;
}

int firstNumber = InputInt("первое");
int secondNumber = InputInt("второе");
int thirdNumber = InputInt("третье");

bool check = CheckNumber(firstNumber, secondNumber, thirdNumber);
Console.WriteLine(check);
