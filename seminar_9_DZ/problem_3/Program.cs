// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string msg)
{
    Console.Write($"{msg} -> ");
    return int.Parse(Console.ReadLine());
}

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

int numberM = Prompt("Vvedite pervoe cislo");
int numberN = Prompt("Vvedite vtoroe cislo");

int result = AkkermanFunction(numberM, numberN);
Console.WriteLine($"{result} ");