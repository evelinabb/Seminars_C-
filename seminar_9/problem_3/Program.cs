// Задача 3: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9



int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}


int ShowNumbers(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number%10+ShowNumbers(number/10);
}

int num = Prompt("Vvedite cislo -> ");
int resultNum = ShowNumbers(num);
Console.WriteLine(resultNum);



