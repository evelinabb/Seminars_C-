//Напишите программу, которая принимает на взод три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

//Теорема о неравенстве треугольника: каждая сторона теругольника меньше суммы двух других сторон

int InputData(string msg)
{
    Console.WriteLine($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckSides(int a, int b, int c)
{
    return (a + b > c && a + c > c && b + c > a);
}

int side1 = InputData("Vvedite razmer storony a");
int side2 = InputData("Vvedite razmer storony b");
int side3 = InputData("Vvedite razmer storony c");
System.Console.WriteLine(CheckSides(side1, side2, side3));
