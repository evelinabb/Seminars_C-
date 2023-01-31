//Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}


int Factorial(int number)
{
    
    // int fakt = 1;                                    //toze pravilno
    // for (int i = 1; i <= number; i++)
    // {
    //     fakt *= i;
    // }
    // return fakt;

    int fact = 1;
    while(number >0)
    {
        fact *= number;
        number -=1;
    }
    return fact;
}


int number = Prompt("Vvedite cislo");
Console.WriteLine($"Factorial cisla {number} = {Factorial(number)}");

