// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

string FindCoordiantes(int quarterNumber)
{
    if (quarterNumber == 1)
    {
        return "X > 0; Y > 0";
    }
    if (quarterNumber == 2)
    {
        return "X < 0; Y > 0";
    }
    if (quarterNumber == 3)
    {
        return "X < 0; Y < 0";
    }
    else
    {
        return "X > 0; Y < 0";
    }
}

bool Validate(int number)
{
    if (number < 1 || number > 4)
    {
        System.Console.WriteLine("Такой четверти нет");
        return false;
    }
    return true;
}

int quarter = PromptInt("Введите номер четверти");
if (Validate(quarter))
{
    string coords = FindCoordiantes(quarter);
    Console.WriteLine(coords);
}