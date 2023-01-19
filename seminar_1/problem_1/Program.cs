/* Напишите программу, которая на вход принимает число 
и выдаёт его квадрат (число умноженное на само себя).
Например: 4 -> 16; -3 -> 9; -7 -> 49 */

Console.Write("Введите число > ");
string strValue = Console.ReadLine();
int value;
value = Convert.ToInt32(strValue);

int result = value * value;

Console.WriteLine($"Квадрат числа {value} равен {result}");




