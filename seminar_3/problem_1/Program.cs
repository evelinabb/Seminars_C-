// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Подсказка и ввод числа
int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

bool ValidateCoords(int xCoord, int yCoord)
{
    if (xCoord == 0 || yCoord == 0)
    {
        Console.WriteLine("Хотя бы одна координата находится на оси");
        return false;
    }
    return true;
}

int GetQuarter(int xCoord, int yCoord)
{
    if (xCoord > 0 && yCoord > 0)
    {
        return 1;
    }
    if (xCoord > 0 && yCoord < 0)
    {
        return 4;
    }
    if (xCoord < 0 && yCoord > 0)
    {
        return 2;
    }
    return 3;
}

int x = PromptInt("Введите x");
int y = PromptInt("Введите y");
if (ValidateCoords(x,y))
{
    int quarter = GetQuarter(x,y);
    Console.WriteLine($"Номер четверти {quarter}");
}