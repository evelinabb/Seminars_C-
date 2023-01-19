/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите число больше 1 > ");
int numberN = Convert.ToInt32(Console.ReadLine());
int evenCount = 2;

if (numberN > 0)
{
    while (evenCount <= numberN)
    {
        Console.Write(evenCount + ", ");
        evenCount = evenCount + 2;
    }
}
else
Console.WriteLine("Введите число больше 1");
