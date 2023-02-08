// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double[] IntersectionArray(double num1, double num2, double num3, double num4)
{
    double[] array = new double[2];
    array[0] = (num3 - num1) / (num2 - num4);
    array[1] = num2 * array[0] + num1;
    return array;
}

void PrintArray(double[] array, string message)
{
    Console.Write(message);
    Console.Write("(" + array[0] + ", ");
    Console.Write(array[1] + ")");

}

int numberb1 = InputInt("Vvedite b1 > ");
int numberk1 = InputInt("Vvedite k1 > ");
int numberb2 = InputInt("Vvedite b2 > ");
int numberk2 = InputInt("Vvedite k2 > ");
double[] coordinates = IntersectionArray(numberb1, numberk1, numberb2, numberk2);
PrintArray(coordinates, "Tocka peresecenia imeet koordinaty:");


