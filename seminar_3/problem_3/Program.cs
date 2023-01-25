// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

double FindLength(int xOne, int yOne, int xTwo, int yTwo)
{
    double catet1 = Math.Pow(xOne - xTwo, 2);
    double catet2 = Math.Pow(yOne - yTwo, 2);
    double gipotenusa = Math.Sqrt(catet1+catet2);
    return gipotenusa;
}

int dot1X = PromptInt("Введите точку X1");
int dot1Y = PromptInt("Введите точку Y1");
int dot2X = PromptInt("Введите точку X2");
int dot2Y = PromptInt("Введите точку Y2");
double letgthBetwPoints = FindLength(dot1X, dot1Y, dot2X, dot2Y);
Console.WriteLine($"Расстояние между точками: {letgthBetwPoints:F2}");