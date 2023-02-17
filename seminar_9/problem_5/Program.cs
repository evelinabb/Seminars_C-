// Oпределите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”



int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}


/*bool CheckBinary(int num)
{
    if (num == 1)
    {
        return true;
    }
    if (num % 2 != 0)
    {
        return false;
    }
    return CheckBinary(num/2);
}*/

bool CheckBinary(int num)
{
    if (num == 1)
    {
        return true;
    }
    return (num % 2 == 0) && CheckBinary(num/2);
}



int number = Prompt("Vvedite cislo -> ");

bool resultNum = CheckBinary(number);
Console.WriteLine(resultNum);
