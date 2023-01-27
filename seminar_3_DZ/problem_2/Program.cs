// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int PromptInt(string message)
{
    Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

double FindLength(int xOne, int yOne, int zOne, int xTwo, int yTwo, int zTwo)
{
    double gipotenusa = Math.Sqrt(Math.Pow(xTwo - xOne, 2) + Math.Pow(yTwo - yOne, 2) + Math.Pow(zTwo - zOne, 2));
    return gipotenusa;
}

int dot1X = PromptInt("Введите точку X1");
int dot1Y = PromptInt("Введите точку Y1");
int dot1Z = PromptInt("Введите точку Z1");
int dot2X = PromptInt("Введите точку X2");
int dot2Y = PromptInt("Введите точку Y2");
int dot2Z = PromptInt("Введите точку Z2");
double letgthBetwPoints = FindLength(dot1X, dot1Y, dot1Z, dot2X, dot2Y, dot2Z);
Console.WriteLine($"Расстояние между точками: {letgthBetwPoints:F2}");

