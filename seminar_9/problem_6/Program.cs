// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”




int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}


bool CheckPrimary(int number, int divider)
{
    if (divider == 1)
        return true;
    if (number % divider == 0)
        return false;
    return CheckPrimary(number, divider - 1);
}

int num1 = Prompt("Vvedite cislo -> ");

bool resultNum = CheckPrimary(num1, num1-1);
Console.WriteLine(resultNum);
