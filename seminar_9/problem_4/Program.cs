// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}


int PowNumbers(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    return a* PowNumbers(a, n-1);
}

int num1 = Prompt("Vvedite osnovanie -> ");
int num2 = Prompt("Vvedite stepen -> ");
int resultNum = PowNumbers(num1, num2);
Console.WriteLine(resultNum);






