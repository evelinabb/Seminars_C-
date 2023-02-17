// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string msg)
{
    Console.Write($"{msg} -> ");
    return int.Parse(Console.ReadLine());
}

int SumNumbers(int first, int last)
{
    if (first>last)
    {
        return 0;
    }
    return first + SumNumbers(first+1, last);
}


int numberM = Prompt("Vvedite pervoe cislo");
int numberN = Prompt("Vvedite poslednee cislo");
int result = SumNumbers(numberM, numberN);
Console.WriteLine($"Summa cisel ot {numberM} do {numberN} ravna {result}");

