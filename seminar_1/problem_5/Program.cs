//Напишите программу, которая на вход принимает значение, 
//а на выходе показывает обратное значение. 1 -> 1 2 -> 0.5 0.25 -> 4

Console.Write("Введите число > ");
double number = Convert.ToDouble(Console.ReadLine());

double invNumber = 1 / number;

Console.WriteLine($"Число {invNumber} обратное числу {number}");
